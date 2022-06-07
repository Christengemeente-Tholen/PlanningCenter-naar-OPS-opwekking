using System;
using System.Windows.Forms;

namespace PlanningCenter_to_OPS
{
    public partial class EditSearchForm : Form
    {
        private Config config;
        private string opw_selector;
        private string kopw_selector;
        private bool opw_selector_enabled;
        private bool kopw_selector_enabled;
        private bool opw_case_sensitive;
        private bool kopw_case_sensitive;

        public EditSearchForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormClosing += EditFormClosing;
        }
        private void EditSongSearch_Load(object sender, EventArgs e)
        {
            config = new Config();
            opw_selector = config.opw_selector;
            OpwekkingText.Text = opw_selector;
            kopw_selector = config.kopw_selector;
            KinderText.Text = kopw_selector;
            opw_selector_enabled = config.opw_selector_enabled;
            OpwekkingCheckBox.Checked = opw_selector_enabled;
            kopw_selector_enabled = config.kopw_selector_enabled;
            KinderCheckBox.Checked = kopw_selector_enabled;
            opw_case_sensitive = config.opw_case_sensitive;
            OpwCaseSensitive.Checked = opw_case_sensitive;
            kopw_case_sensitive = config.kopw_case_sensitive;
            KopwCaseSensitive.Checked = kopw_case_sensitive;
        }
        private void EditFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!opw_selector.Equals(config.opw_selector)
                && !kopw_selector.Equals(config.kopw_selector)
                && !opw_selector_enabled.Equals(config.opw_selector_enabled)
                && !kopw_selector_enabled.Equals(config.kopw_selector_enabled)
                && !opw_case_sensitive.Equals(config.opw_case_sensitive)
                && !kopw_case_sensitive.Equals(config.kopw_case_sensitive)
                )
            {
                DialogResult dialogResult = MessageBox.Show("Je hebt veranderingen die niet opgeslagen zijn, wilt u ze opslaan?", "Liedherkenning bewerken", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Save();
                }
            }
        }
        private void Save()
        {
            if (!opw_selector.Contains("*") && !kopw_selector.Contains("*"))
            {
                DialogResult dialogResult = MessageBox.Show("Gebruik minimaal 1 \"*\" in zowel opwekking als kinderliederen", "Liedherkenning bewerken", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK) { }
            } else
            {
                config.opw_selector = opw_selector;
                config.kopw_selector = kopw_selector;
                config.opw_selector_enabled = opw_selector_enabled;
                config.kopw_selector_enabled = kopw_selector_enabled;
                config.opw_case_sensitive = opw_case_sensitive;
                config.kopw_case_sensitive = kopw_case_sensitive;
                config.Update();
                this.Close();
            }
        }

        private void OpwekkingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            opw_selector_enabled = OpwekkingCheckBox.Checked;
        }

        private void KinderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            kopw_selector_enabled = KinderCheckBox.Checked;
        }

        private void OpwCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            opw_case_sensitive = OpwCaseSensitive.Checked;
        }

        private void KopwCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            kopw_case_sensitive = KopwCaseSensitive.Checked;
        }

        private void OpwekkingText_TextChanged(object sender, EventArgs e)
        {
            opw_selector = OpwekkingText.Text;
        }

        private void KinderText_TextChanged(object sender, EventArgs e)
        {
            kopw_selector = KinderText.Text;
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
