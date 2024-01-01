using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlanningCenter_to_OPS.Actions
{
    internal class SongInfo
    {
        public string Type;
        public int? Id;
        public Structs.SongListData Detailed;

        public SongInfo(string type, int? id, Structs.SongListData detailed)
        {
            this.Type = type;
            this.Id = id;
            this.Detailed = detailed;
        }
    }

    internal class DrawFormItems
    {
        private Structs.SongListData SongInfo { get; set; }
        private string Type { get; set; }
        private string SongId { get; set; }
        private Dictionary<string, Structs.Song> FoundSongs = new Dictionary<string, Structs.Song>();
        private ComboBox ComboBox = new ComboBox();


        public static int StartX { get; set; } = 20;
        public static int StartY { get; set; } = 40;
        public static List<Structs.Song> OwnSongs;
        public DrawFormItems(Structs.SongListData song_info, string type, string song_id)
        {
            this.SongInfo = song_info;
            this.Type = type;
            this.SongId = song_id;
        }

        public void Render(Form f)
        {
            Label label = new Label();
            ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            label.Text = SongInfo.attributes.title;
            label.Width = 150;
            if (this.Type != "")
            {
                ComboBox.Items.Add($"{this.Type} {this.SongId}");
            }
            foreach (var song in OwnSongs.Where(song => SongInfo.attributes.title.ToLower().Contains(song.name)))
            {
                ComboBox.Items.Add($"et {song.id} - {song.name}");
                FoundSongs.Add($"et {song.id} - {song.name}", song);
            };
            ComboBox.Items.Add("Planning center");
            ComboBox.SelectedIndex = 0;
            ComboBox.Width = 250;
            // prevent scrolling from accidentally changing values in this list
            ComboBox.MouseWheel += (o, e) => ((HandledMouseEventArgs)e).Handled = true;

            label.Left = StartX;
            label.Top = StartY;
            StartX += 150; // Move position to right
            ComboBox.Left = StartX;
            ComboBox.Top = StartY - 4;
            StartX = 20; // Reset to start
            StartY += 30; // Move position to down
            f.Controls.Add(label);
            f.Controls.Add(ComboBox);
        }

        internal static void RenderTitle(Form f, string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Left = StartX;
            label.Top = StartY;
            label.Width = 400;
            label.ForeColor = System.Drawing.Color.Gray;
            StartY += 30;
            f.Controls.Add(label);
        }

        public SongInfo GetSelectedSong()
        {
            if (this.ComboBox.SelectedItem == null) return new SongInfo ("", null, this.SongInfo);
            string selected = (string)this.ComboBox.SelectedItem;
            if (FoundSongs.TryGetValue(selected, out var found_song))
            {
                return new SongInfo ("et", found_song.id, this.SongInfo);
            } else if (selected == "Planning center")
            {
                return new SongInfo("file", null, this.SongInfo);
            }
            return new SongInfo (this.Type, Int32.Parse(this.SongId), this.SongInfo);
        }
    }
}
