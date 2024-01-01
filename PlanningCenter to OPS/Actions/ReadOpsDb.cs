using ClosedXML.Excel;
using Microsoft.Data.Sqlite;
using PlanningCenter_to_OPS.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlanningCenter_to_OPS.Actions
{
    internal class ReadOpsDb
    {
        public IDictionary<string, List<Song>> books;
        public ReadOpsDb()
        {
            // using (var connection = new SqliteConnection("Data Source=E:\\code\\C#\\PlanningCenter-naar-OPS-opwekking-\\songs.search.sqlite"))
            using (var connection = new SqliteConnection("Data Source=C:\\ProgramData\\Stichting Opwekking\\OPS 8\\songs.search.sqlite"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT title
                    FROM song_index
                ";
                IDictionary<string, List<Song>> song_lists = new Dictionary<string, List<Song>>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] current_song = reader.GetString(0).Split(' ');
                        _ = int.TryParse(string.Concat(current_song[0].Where(char.IsNumber)), out int song_number);

                        string last_item = string.Concat(current_song.Last().Where(char.IsLetter));
                        if (!song_lists.TryGetValue(last_item, out _))
                        {
                            song_lists.Add(last_item, new List<Structs.Song>());
                        }
                        song_lists[last_item].Add(new Structs.Song(song_number, string.Join(" ", current_song.Skip(1).ToArray().SkipLast(last_item.Length))));
                    }
                }
                this.books = song_lists;
            }
        }


        public void Export()
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                foreach (KeyValuePair<string, List<Structs.Song>> entry in this.books)
                {
                    IXLWorksheet worksheet = workbook.Worksheets.Add(entry.Key);
                    worksheet.Cell(1, 1).Value = "Liednummer";
                    worksheet.Cell(1, 2).Value = "Titel";
                    for (int i = 1; i < entry.Value.Count; i++)
                    {
                        worksheet.Cell(i + 1, 1).Value = entry.Value[i].id;
                        worksheet.Cell(i + 1, 2).Value = entry.Value[i].name;
                    }
                }

                SaveFileDialog oSaveFileDialog = new SaveFileDialog();
                oSaveFileDialog.Filter = "Excel Workbook (*.xlsx) | *.xlsx";
                oSaveFileDialog.FileName = "OPS liederen.xlsx";
                oSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(oSaveFileDialog.FileName);
                }
            }
        }

        public List<string> SongIdsByBook(string book)
        {
            List<string> song_ids = new List<string>();
            if (this.books.TryGetValue(book, out List<Song> songs))
            {
                foreach (Song song in songs)
                {
                    song_ids.Add(song.id.ToString());
                }
                return song_ids;
            }
            return new List<string>();
        }

        public List<string> SongNameByBook(string book)
        {
            List<string> song_names = new List<string>();
            if (this.books.TryGetValue(book,out List<Song> songs))
            { 
                foreach (Song song in songs) 
                {  
                    song_names.Add(song.name);
                }
                return song_names;
            }
            return new List<string>();
        }
    }
}
