using ClosedXML.Excel;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlanningCenter_to_OPS.Actions
{
    internal class SonglistToExcel
    {
        private static void Export(IDictionary<string, List<Tuple<int, string>>> song_lists)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                foreach (KeyValuePair<string, List<Tuple<int, string>>> entry in song_lists)
                {
                    IXLWorksheet worksheet = workbook.Worksheets.Add(entry.Key);
                    worksheet.Cell(1, 1).Value = "Liednummer";
                    worksheet.Cell(1, 2).Value = "Titel";
                    for (int i = 1; i < entry.Value.Count; i++)
                    {
                        worksheet.Cell(i + 1, 1).Value = entry.Value[i].Item1;
                        worksheet.Cell(i + 1, 2).Value = entry.Value[i].Item2;
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

        public static void GetSongs()
        {
            using (var connection = new SqliteConnection("Data Source=C:\\ProgramData\\Stichting Opwekking\\OPS 8\\songs.search.sqlite"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT title
                    FROM song_index
                ";
                IDictionary<string, List<Tuple<int, string>>> song_lists = new Dictionary<string, List<Tuple<int, string>>>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] current_song = reader.GetString(0).Split(' ');
                        _ = int.TryParse(string.Concat(current_song[0].Where(char.IsNumber)), out int song_number);

                        string last_item = string.Concat(current_song.Last().Where(char.IsLetter));
                        if (!song_lists.TryGetValue(last_item, out _))
                        {
                            song_lists.Add(last_item, new List<Tuple<int, string>>());
                        }
                        song_lists[last_item].Add(new Tuple<int, string>(song_number, string.Join(" ", current_song.Skip(1).ToArray().SkipLast(last_item.Length))));
                    }
                }
                SonglistToExcel.Export(song_lists);
            }
        }
    }
}
