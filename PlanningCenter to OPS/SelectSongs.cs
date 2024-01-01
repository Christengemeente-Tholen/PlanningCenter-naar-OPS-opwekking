using PlanningCenter_to_OPS.Actions;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PlanningCenter_to_OPS
{
    internal partial class SelectSongs : Form
    {
        private Button ContinueButton = new Button();
        private Config Config { get; set; }
        private Structs.SongList SongList { get; set; }
        private List<DrawFormItems> SongDropdowns = new List<DrawFormItems>();

        internal SelectSongs(Config config, Structs.SongList song_list)
        {
            InitializeComponent();
            this.Config = config;
            this.SongList = song_list;

            this.AutoScroll = true;
            //MainPanel.AutoScroll = true;
        }

        private void SelectSongs_Load(object sender, EventArgs e)
        {
            ReadOpsDb db_reader = new ReadOpsDb();
            List<string> opw_songs = db_reader.SongIdsByBook("opw");
            List<string> kopw_songs = db_reader.SongIdsByBook("kopw");
            List<Structs.Song> own_songs = new List<Structs.Song>();
            if (db_reader.books.TryGetValue(this.Config.et_abbreviation, out List<Structs.Song> found))
            {
                own_songs = found;
            }

            // reset positioning on statup
            DrawFormItems.StartX = 20;
            DrawFormItems.StartY = 40;
            DrawFormItems.OwnSongs = own_songs;

            if (this.SongList.data.Count <= 0)
            {
                DrawFormItems.RenderTitle(this, "Dit plan is nog leeg!");
            }

            this.SongList.data.ForEach(x =>
            {
                if (x.attributes.item_type == "song")
                {
                    DrawFormItems song_element;
                    Match isOpw = new Regex(
                        String.Format(RegexCaseString(this.Config.opw_case_sensitive),
                        this.Config.opw_selector.Replace("*", "(\\d*)")))
                            .Match(x.attributes.title);
                    Match isKopw = new Regex(
                        String.Format(RegexCaseString(this.Config.kopw_case_sensitive),
                        this.Config.kopw_selector.Replace("*", "(\\d*)")))
                            .Match(x.attributes.title);
                    if (isOpw.Value.Length > 0 && this.Config.opw_selector_enabled && opw_songs.Contains(isOpw.Groups[1].Value.TrimStart('0')))
                    {
                        song_element = new DrawFormItems(x, "opw", isOpw.Groups[1].Value.TrimStart('0'));
                    }
                    else if (isKopw.Value.Length > 0 && this.Config.kopw_selector_enabled && kopw_songs.Contains(isKopw.Groups[1].Value.TrimStart('0')))
                    {
                        song_element = new DrawFormItems(x, "kopw", isKopw.Groups[1].Value.TrimStart('0'));
                    }
                    else
                    {
                        song_element = new DrawFormItems(x, "", "");
                    }
                    song_element.Render(this);
                    this.SongDropdowns.Add(song_element);
                } else
                {
                    if (x.attributes.item_type == "header")
                    {
                        DrawFormItems.RenderTitle(this, x.attributes.title);
                    }
                }
            });

            ContinueButton.Text = "Doorgaan";
            ContinueButton.Left = DrawFormItems.StartX;
            ContinueButton.Top = DrawFormItems.StartY - 5;
            ContinueButton.Width = 400;
            ContinueButton.Height = 25;
            ContinueButton.Click += ContinueButton_Click;
            this.Controls.Add(ContinueButton);

            DrawFormItems.StartY += 10;
            Label label = new Label();
            label.Text = "";
            label.Top = DrawFormItems.StartY;
            label.Left = DrawFormItems.StartX;
            this.Controls.Add(label);
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            ToXml.CreateXml(this.Config, this.SongDropdowns);
            this.Close();
        }

        internal static string RegexCaseString(bool case_sensitive)
        {
            if (case_sensitive)
            {
                return @"^{0}";
            }
            return @"^(?i){0}";
        }
    }
}
