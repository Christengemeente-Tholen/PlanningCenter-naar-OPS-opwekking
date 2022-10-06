using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;
using PlanningCenter_to_OPS.Actions;

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
                ServiceTypesInfo = UpdateView.UpdateServiceType(config, ServiceTypeSelector.Items);
                Console.WriteLine(ServiceTypesInfo);
            }
            catch (NotImplementedException e)
            {
                ServiceTypeSelector.Items.Clear();
                Console.WriteLine(e.Message);
                OrganisationName.Text = "Gekoppeld aan: " + "niet gekoppeld / " + e.Message;
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
            if (ServiceTypesInfo.ContainsKey(current))
            {
                PlansInfo = UpdateView.UpdatePlans(config, PlanSelector.Items, ServiceTypesInfo[current]);
            }
        }

        private void PlanSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string current = (string)cmb.SelectedItem;
            if (PlansInfo.ContainsKey(current))
            {
                this.current_plan = current;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (current_plan != null)
            {
                try
                {
                    Structs.SongList song_return = Api.GetSongList(config, PlansInfo[current_plan]);
                    ToXml.CreateXml(config, song_return, current_plan);
                } catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditOpsSkipList_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo() { FileName = "C:\\ProgramData\\Stichting Opwekking\\OPS 8\\opsSkipList.txt", UseShellExecute = true });
            } catch (Win32Exception winE)
            {
                MessageBox.Show(winE.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var edit_search = new EditSearchForm())
            {
                DialogResult result = edit_search.ShowDialog();
                this.RefreshItems();
            }
        }
    }
}
