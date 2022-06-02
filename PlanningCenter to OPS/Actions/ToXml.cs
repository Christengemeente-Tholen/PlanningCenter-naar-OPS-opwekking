using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using PlanningCenter_to_OPS.BookTypes;

namespace PlanningCenter_to_OPS.Actions
{
    internal class ToXml
    {

        internal static XElement SongNode(string song_name, string song_type)
        {
            BookType book = Init.GetType(song_type, song_name);

            XElement doc = new XElement("Song", 
                new XElement("Comment"),
                new XElement("DisplayTitle", song_name),
                new XElement("DisplayTitleShort", song_name),
                new XElement("Number", book.SongNumber),
                new XElement("SongBookName", book.SongBookName),
                new XElement("Keys"),
                new XElement("StyleName", book.StyleName),
                new XElement("Title", book.Title),
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

        internal static XElement GetSongs(Config config, Structs.SongList song_list)
        {
            XElement xml_list = new XElement("Items");
            song_list.data.ForEach(x =>
            {
                if (x.attributes.item_type == "song")
                {
                    if (Decimal.TryParse(x.attributes.title.Split()[0], out _))
                    {
                        xml_list.Add(SongNode(x.attributes.title, "opw"));
                    } else if (x.attributes.title.Split()[0].ToLower() == "kopw")
                    {
                        xml_list.Add(SongNode(x.attributes.title, "kopw"));
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
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                doc.Save(oSaveFileDialog.FileName);
            }
        }
    }
}
