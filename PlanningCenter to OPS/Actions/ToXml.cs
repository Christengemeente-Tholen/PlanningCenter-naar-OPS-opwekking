using System;
using System.Windows.Forms;
using System.Xml.Linq;
using PlanningCenter_to_OPS.BookTypes;
using System.Collections.Generic;

namespace PlanningCenter_to_OPS.Actions
{
    internal class ToXml
    {

        internal static XElement SongNode(Config config, string song_name, string song_type, string song_number)
        {
            BookType book = Init.GetType(config, song_type);

            XElement doc = new XElement("Song", 
                new XElement("Comment"),
                new XElement("DisplayTitle", song_name),
                new XElement("DisplayTitleShort", song_name),
                new XElement("Number", song_number),
                new XElement("SongBookName", book.SongBookName),
                new XElement("Keys"),
                new XElement("StyleName", config.last_used_ops_theme),
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

        internal static XElement SongFileNode(Config config, string song_name)
        {
            XElement doc = new XElement("SongFromFile",
                new XElement("Comment"),
                new XElement("DisplayTitle", song_name),
                new XElement("FileName", String.Format("{0}\\{1}.txt", config.song_folder, song_name)),
                new XElement("StyleName", config.last_used_ops_theme)
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

        internal static XElement GetSongs(Config config, List<DrawFormItems> song_list)
        {
            XElement xml_list = new XElement("Items");
            song_list.ForEach(x =>
            {
                SongInfo current = x.GetSelectedSong();
                string title = current.Detailed.attributes.title; 
                if (current.Type == "opw")
                {
                    xml_list.Add(SongNode(config, title, "opw", current.Id.ToString()));
                } else if (current.Type == "kopw")
                {
                    xml_list.Add(SongNode(config, title, "kopw", current.Id.ToString()));
                } else if (current.Type == "file")
                {
                    LyricsToFile.ToFile(config, current.Detailed);
                    xml_list.Add(SongFileNode(config, title));
                } else
                {
                    xml_list.Add(SongNode(config, title, config.et_abbreviation, current.Id.ToString()));
                }
            });
            return xml_list;
        }

        internal static void CreateXml(Config config, List<DrawFormItems> song_list)
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
