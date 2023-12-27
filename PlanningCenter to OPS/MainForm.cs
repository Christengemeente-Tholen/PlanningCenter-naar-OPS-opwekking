using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;
using PlanningCenter_to_OPS.Actions;
using Microsoft.Data.Sqlite;
using NsExcel = Microsoft.Office.Interop.Excel;

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
                Process.Start(new ProcessStartInfo() { FileName = "C:\\ProgramData\\Stichting Opwekking\\OPS 8\\opsSkipList.txt", UseShellExecute = true });
            }
            catch (Win32Exception winE)
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

        private void ReadSongs_Click(object sender, EventArgs e)
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
                List<string> list = new List<string>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
                ListToExcel(list);
            }
        }

        public void ListToExcel(List<string> list)
        {
            //start excel
            NsExcel.ApplicationClass excapp = new Microsoft.Office.Interop.Excel.ApplicationClass();

            //if you want to make excel visible           
            excapp.Visible = true;

            //create a blank workbook
            //Microsoft.Office.Interop.Excel.Workbook workbook = excapp.Workbooks.Add(NsExcel.XlWBATemplate.xlWBATWorksheet);

            //or open one - this is no pleasant, but yue're probably interested in the first parameter
            string workbookPath = "C:\test.xls";
            Microsoft.Office.Interop.Excel.Workbook workbook = excapp.Workbooks.Open(workbookPath,
                0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "",
                true, false, 0, true, false, false);

            //Not done yet. You have to work on a specific sheet - note the cast
            //You may not have any sheets at all. Then you have to add one with NsExcel.Worksheet.Add()
            var sheet = (NsExcel.Worksheet)workbook.Sheets[1]; //indexing starts from 1

            //do something usefull: you select now an individual cell
            var range = sheet.get_Range("A1", "A1");
            range.Value2 = "test"; //Value2 is not a typo

            //now the list
            string cellName;
            int counter = 1;
            foreach (var item in list)
            {
                cellName = "A" + counter.ToString();
                var current = sheet.get_Range(cellName, cellName);
                current.Value2 = item.ToString();
                ++counter;
            }

            //you've probably got the point by now, so a detailed explanation about workbook.SaveAs and workbook.Close is not necessary
            //important: if you did not make excel visible terminating your application will terminate excel as well - I tested it
            //but if you did it - to be honest - I don't know how to close the main excel window - maybee somewhere around excapp.Windows or excapp.ActiveWindow
        }
    }

}
