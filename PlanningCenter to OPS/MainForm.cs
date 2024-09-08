using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;
using PlanningCenter_to_OPS.Actions;
using System.Xml;

namespace PlanningCenter_to_OPS
{
    public partial class MainForm : Form
    {
        private Config config;
        private Dictionary<string, string> ServiceTypesInfo = new Dictionary<string, string>();
        private Dictionary<string, string> PlansInfo = new Dictionary<string, string>();
        private string current_plan;
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshItems();
        }

        public void RefreshItems()
        {
            config = new Config();
            this.current_plan = null;
            SongLocationLabel.Text = "Lied locatie: " + config.song_folder;
            PlanSelector.Items.Clear();
            try
            {
                OrganisationName.Text = "Gekoppeld aan: " + Api.GetOrg(config).data.attributes.name;
                (ServiceTypesInfo, PlansInfo) = UpdateView.UpdateServiceType(config, ServiceTypeSelector, PlanSelector, PlansInfo);
                CheckPlan();
            }
            catch (NotImplementedException e)
            {
                ServiceTypeSelector.Items.Clear();
                OrganisationName.Text = "Gekoppeld aan: " + "niet gekoppeld / " + e.Message;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\ProgramData\\Stichting Opwekking\\OPS 8\\Themes.xml");
            OpsThemeSelector.Items.Clear();
            foreach (XmlNode node in doc.GetElementsByTagName("ThemeName"))
            {
                OpsThemeSelector.Items.Add(node.InnerText);
            }
            if (config.last_used_ops_theme != "")
            {
                OpsThemeSelector.SelectedItem = config.last_used_ops_theme;
            } else
            {
                OpsThemeSelector.SelectedIndex = 0;
            }

            config.ReadSkipList();
        }

        private void CheckPlan()
        {
            string current = (string)PlanSelector.SelectedItem;
            if (current == null) return;
            if (PlansInfo.ContainsKey(current))
            {
                this.current_plan = current;
            }
        }

        private void EditLogin_Click(object sender, EventArgs e)
        {
            using (var edit_auth = new SetAuthForm())
            {
                DialogResult result = edit_auth.ShowDialog();
                this.RefreshItems();
            }
        }

        private void EditSongLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                config.song_folder = dialog.SelectedPath;
                config.Update();
                this.RefreshItems();
            }
        }

        private void ServiceTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string current = (string)cmb.SelectedItem;
            if (current == null) return;
            if (ServiceTypesInfo.ContainsKey(current))
            {
                PlansInfo = UpdateView.UpdatePlans(config, PlanSelector, ServiceTypesInfo[current]);
                CheckPlan();
            }
        }

        private void PlanSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckPlan();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            config.Update();
            if (current_plan != null)
            {
                try
                {
                    Structs.SongList song_return = Api.GetSongList(config, PlansInfo[current_plan]);
                    using (SelectSongs select_songs = new SelectSongs(config, song_return))
                    {
                        DialogResult result = select_songs.ShowDialog();
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditOpsSkipList_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo() { FileName = config.skip_list_location, UseShellExecute = true });
            }
            catch (Win32Exception winE)
            {
                MessageBox.Show(winE.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (EditSearchForm edit_search = new EditSearchForm())
            {
                DialogResult result = edit_search.ShowDialog();
                this.RefreshItems();
            }
        }

        private void ReadSongs_Click(object sender, EventArgs e)
        {
            ReadOpsDb db_reader = new ReadOpsDb(true);
            db_reader.Export();
        }

        private void OpsThemeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string current = (string)cmb.SelectedItem;
            if (current == null) return;
            config.last_used_ops_theme = current;
        }
    }

}
