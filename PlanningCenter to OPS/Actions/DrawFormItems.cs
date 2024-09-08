using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PlanningCenter_to_OPS.Actions
{
    public partial class UcLabel : Label
    {
        public ToolTip ToolTip = new ToolTip() { AutomaticDelay = 1500, InitialDelay = 400, UseAnimation = true, UseFading = true, Active = true };
        public string TooltipText { get; set; }
    }

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

    internal class DpiScale
    {
        public float DpiX;
        public float DpiY;

        public DpiScale(float dpiX, float dpiY)
        {
            DpiX = dpiX;
            DpiY = dpiY;
        }
    }

    internal class DrawFormItems
    {
        private static string SongTextInfo = "Lyrics:";

        private Structs.SongListData SongInfo { get; set; }
        private string Type { get; set; }
        private string SongId { get; set; }
        private Config Config { get; set; }

        public static Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);
        public static DpiScale dpi_scale = new DpiScale(graphics.DpiX / 96, graphics.DpiY / 96);

        private UcLabel Label = new UcLabel() { Width = (int)Math.Round(150 * dpi_scale.DpiX), Height = (int)Math.Round(new UcLabel().Height * dpi_scale.DpiY) };
        private Dictionary<string, Structs.Song> FoundSongs = new Dictionary<string, Structs.Song>();
        private Dictionary<string, string> SongTooltipInfo = new Dictionary<string, string>();
        private ComboBox ComboBox = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, DrawMode = DrawMode.OwnerDrawFixed, Width = (int)Math.Round(250 * dpi_scale.DpiX) };
        private Button CopyButton = new Button() { Text = "Kopieer lyrics", Width = (int)Math.Round(90 * dpi_scale.DpiX), Height = (int)Math.Round(new UcLabel().Height * dpi_scale.DpiY) };
        private ToolTip ToolTip = new ToolTip() { AutoPopDelay = 0, InitialDelay = 0, ReshowDelay = 0, ShowAlways = true };

        public static int StartX { get; set; } = (int)Math.Round(20 * DrawFormItems.dpi_scale.DpiX);
        public static int StartY { get; set; } = (int)Math.Round(40 * DrawFormItems.dpi_scale.DpiX);
        public static List<Structs.Song> OwnSongs;
        public DrawFormItems(Config config, Structs.SongListData song_info, string type, string song_id)
        {
            this.Config = config;
            this.SongInfo = song_info;
            this.Type = type;
            this.SongId = song_id;
        }
        
        private void ComboBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) { return; }
            string item = SongTooltipInfo.GetValueOrDefault(ComboBox.GetItemText(ComboBox.Items[e.Index]));
            string tooltipText = "";
            if (!string.IsNullOrEmpty(item))
            {
                string songText = ReadOpsDb.GetSongText(item);
                tooltipText = GenerateSongTextInfo(songText);
            }
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(ComboBox.GetItemText(ComboBox.Items[e.Index]), e.Font, br, e.Bounds);
            }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected && ComboBox.DroppedDown && tooltipText != null)
            {
                ToolTip.Show(tooltipText, ComboBox, e.Bounds.Right, e.Bounds.Bottom + 4);
            } else
            {
                ToolTip.Hide(ComboBox);
            }
            e.DrawFocusRectangle();
        }

        private void ComboBoxOnClose(object sender, EventArgs e)
        {
            ToolTip.Hide(ComboBox);
        }

        public void Render(Form f, Config config)
        {
            Label.Text = SongInfo.attributes.title;
            Label.TooltipText = "test";
            Label.MouseEnter += new EventHandler(this.Label_MouseEnter);
            if (this.Type != "")
            {
                ComboBox.Items.Add($"{this.Type} {this.SongId}");
                SongTooltipInfo.Add($"{this.Type} {this.SongId}", $"{this.Type}{this.SongId}");
            }
            string song_lowercase_title = SongInfo.attributes.title.ToLower();
            ComboBox.DrawItem += ComboBoxDrawItem;
            ComboBox.DropDownClosed += ComboBoxOnClose;
            foreach (var song in OwnSongs.Where(song => song_lowercase_title.Contains(song.name) || song.name.Contains(song_lowercase_title)))
            {
                ComboBox.Items.Add($"et {song.id} - {song.name}");
                FoundSongs.Add($"et {song.id} - {song.name}", song);
                SongTooltipInfo.Add($"et {song.id} - {song.name}", $"{config.et_abbreviation}{song.id}");
            };
            ComboBox.Items.Add("Planning center");
            ComboBox.SelectedIndex = 0;
            // prevent scrolling from accidentally changing values in this list
            ComboBox.MouseWheel += (o, e) => ((HandledMouseEventArgs)e).Handled = true;

            Label.Left = StartX;
            Label.Top = StartY;
            StartX += (int)Math.Round(150 * dpi_scale.DpiX); // Move position to right
            ComboBox.Left = StartX;
            ComboBox.Top = StartY - (int)Math.Round(4 * dpi_scale.DpiY);

            CopyButton.Left = StartX + (int)Math.Round(252 * dpi_scale.DpiX);
            CopyButton.Top = StartY - (int)Math.Round(4 * dpi_scale.DpiY);
            CopyButton.Click += CopyButton_Click;

            StartX = (int)Math.Round(20 * dpi_scale.DpiX); // Reset to start
            StartY += (int)Math.Round(30 * dpi_scale.DpiY); // Move position to down
            f.Controls.Add(Label);
            f.Controls.Add(ComboBox);
            f.Controls.Add(CopyButton);
        }
        
        private string GenerateSongTextInfo(string lyrics)
        {
            string firstFewLines = string.Join(Environment.NewLine, lyrics.Trim().Split(Environment.NewLine).Take(5));
            return SongTextInfo + Environment.NewLine + firstFewLines + Environment.NewLine + "...";
        }

        private void Label_MouseEnter(object sender, EventArgs ea)
        {
            string lyrics = GetLyrics();
            string firstFewLines = GenerateSongTextInfo(lyrics);
            if (!string.IsNullOrEmpty(lyrics))
            {
                Label.ToolTip.SetToolTip(Label, firstFewLines);
                Label.ToolTip.Show(firstFewLines, Label.Parent);
            }
        }

        internal static void RenderTitle(Form f, string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Left = StartX;
            label.Top = StartY;
            label.Width = (int)Math.Round(400 * dpi_scale.DpiX);
            label.ForeColor = System.Drawing.Color.Gray;
            StartY += (int)Math.Round(30 * dpi_scale.DpiY);
            f.Controls.Add(label);
        }

        private string GetLyrics()
        {
            Structs.Lyrics lyrics = Api.GetLyrics(this.Config, this.SongInfo.links.self);
            return LyricsToFile.Lyrics(lyrics.data.attributes.lyrics, this.Config.skip_list);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetLyrics());
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
