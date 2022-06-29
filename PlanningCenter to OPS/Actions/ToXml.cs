using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using PlanningCenter_to_OPS.BookTypes;

namespace PlanningCenter_to_OPS.Actions
{
    internal class ToXml
    {

        internal static XElement SongNode(string song_name, string song_type, string song_number)
        {
            BookType book = Init.GetType(song_type);

            XElement doc = new XElement("Song", 
                new XElement("Comment"),
                new XElement("DisplayTitle", song_name),
                new XElement("DisplayTitleShort", song_name),
                new XElement("Number", song_number),
                new XElement("SongBookName", book.SongBookName),
                new XElement("Keys"),
                new XElement("StyleName", book.StyleName),
                new XElement("Title", song_name),
                new XElement("SelectedVersion", book.SelectedVersion),
                new XElement("Language", "All"),
                new XElement("SongBookPrefix", song_type) // TODO add values
            );
            doc.SetAttributeValue("ID", Guid.NewGuid().ToString());
            doc.SetAttributeValue("Type", "Song");
            doc.SetAttributeValue("IsPackaged", "false");
            return doc;

        }

        internal static XElement SongFileNode(string song_name, string save_location)
        {
            XElement doc = new XElement("SongFromFile",
                new XElement("Comment"),
                new XElement("DisplayTitle", song_name),
                new XElement("FileName", String.Format("{0}\\{1}.txt", save_location, song_name)),
                new XElement("StyleName", "OPS")
            );
            doc.SetAttributeValue("ID", Guid.NewGuid().ToString());
            doc.SetAttributeValue("Type", "Song");
            doc.SetAttributeValue("IsPackaged", "false");
            return doc;
        }

        internal static string RegexCaseString(bool case_sensitive)
        {
            if (case_sensitive)
            {
                return @"^{0}";
            }
            return @"^(?i){0}";
        }

        internal static XElement GetSongs(Config config, Structs.SongList song_list)
        {
            XElement xml_list = new XElement("Items");
            song_list.data.ForEach(x =>
            {
                if (x.attributes.item_type == "song")
                {
                    Match isOpw = new Regex(
                        String.Format(RegexCaseString(config.opw_case_sensitive),
                        config.opw_selector.Replace("*", "(\\d*)")))
                            .Match(x.attributes.title);
                    Match isKopw = new Regex(
                        String.Format(RegexCaseString(config.kopw_case_sensitive),
                        config.kopw_selector.Replace("*", "(\\d*)")))
                            .Match(x.attributes.title);
                    if (isOpw.Value.Length > 0 && config.opw_selector_enabled)
                    {
                        xml_list.Add(SongNode(x.attributes.title, "opw", isOpw.Groups[1].Value.TrimStart('0')));
                    } else if (isKopw.Value.Length > 0 && config.kopw_selector_enabled)
                    {
                        xml_list.Add(SongNode(x.attributes.title, "kopw", isKopw.Groups[1].Value.TrimStart('0')));
                    } else
                    {
                        LyricsToFile.ToFile(config, x);
                        xml_list.Add(SongFileNode(x.attributes.title, config.song_folder));
                    }
                }
            });
            return xml_list;
        }

        internal static void CreateXml(Config config, Structs.SongList song_list, string plan_name)
        {
            DateTime localTime = DateTime.Now;
            DateTimeOffset localTimeAndOffset = new DateTimeOffset(localTime, TimeZoneInfo.Local.GetUtcOffset(localTime));
            XDocument doc = new XDocument(
                new XElement("Playlist",
                    new XElement("CreatedDate", localTimeAndOffset.ToString("o")),
                    new XElement("IsPackage", "false"),
                    GetSongs(config, song_list),
                    new XElement("User", "Builder")
                )
            );

            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "OPS Playlist (*.plsx) | *.plsx";
            oSaveFileDialog.FileName = String.Format("Playlist_{0:yyyy-MM-dd}.plsx", localTime);
            oSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\OPS\\Playlist";
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                doc.Save(oSaveFileDialog.FileName);
            }
        }
    }
}
