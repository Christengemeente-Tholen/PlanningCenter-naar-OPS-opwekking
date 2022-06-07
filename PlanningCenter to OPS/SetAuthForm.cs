using System;
using System.Windows.Forms;

namespace PlanningCenter_to_OPS
{
    public partial class SetAuthForm : Form
    {
        private string app_id;
        private string secret;
        private Config config;
        public SetAuthForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormClosing += EditFormClosing;
        }

        private void SetAuthForm_Load(object sender, EventArgs e)
        {
            config = new Config();
            app_id = config.app_id;
            appIdTextBox.Text = app_id;
            secret = config.secret;
            secretTextBox.Text = secret;
        }

        private void EditFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!app_id.Equals(config.app_id) && !secret.Equals(config.secret))
            {
                DialogResult dialogResult = MessageBox.Show("Je hebt veranderingen die niet opgeslagen zijn, wilt u ze opslaan?", "Api koppelen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Save();
                }
            }
        }

        private void ApiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            apiLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://api.planningcenteronline.com/oauth/applications");
        }

        private void Save()
        {
            config.app_id = app_id;
            config.secret = secret;
            config.Update();
            this.Close();
        }

        private void AppIdTextBox_TextChanged(object sender, EventArgs e)
        {
            app_id = appIdTextBox.Text;
        }

        private void SecretTextBox_TextChanged(object sender, EventArgs e)
        {
            secret = secretTextBox.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
