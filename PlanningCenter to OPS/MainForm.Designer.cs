namespace PlanningCenter_to_OPS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EditLogin = new System.Windows.Forms.Button();
            this.OrganisationName = new System.Windows.Forms.Label();
            this.ServiceTypeSelector = new System.Windows.Forms.ComboBox();
            this.PlanSelector = new System.Windows.Forms.ComboBox();
            this.ServiceTypeText = new System.Windows.Forms.Label();
            this.ServicePlanLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SongLocationLabel = new System.Windows.Forms.Label();
            this.EditSongLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditLogin
            // 
            this.EditLogin.Location = new System.Drawing.Point(615, 22);
            this.EditLogin.Name = "EditLogin";
            this.EditLogin.Size = new System.Drawing.Size(145, 42);
            this.EditLogin.TabIndex = 0;
            this.EditLogin.Text = "Bewerken";
            this.EditLogin.UseVisualStyleBackColor = true;
            this.EditLogin.Click += new System.EventHandler(this.EditLogin_Click);
            // 
            // OrganisationName
            // 
            this.OrganisationName.AutoSize = true;
            this.OrganisationName.Location = new System.Drawing.Point(39, 31);
            this.OrganisationName.Name = "OrganisationName";
            this.OrganisationName.Size = new System.Drawing.Size(170, 25);
            this.OrganisationName.TabIndex = 1;
            this.OrganisationName.Text = "Gekoppeld aan: ";
            // 
            // ServiceTypeSelector
            // 
            this.ServiceTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceTypeSelector.FormattingEnabled = true;
            this.ServiceTypeSelector.Location = new System.Drawing.Point(208, 117);
            this.ServiceTypeSelector.Name = "ServiceTypeSelector";
            this.ServiceTypeSelector.Size = new System.Drawing.Size(552, 33);
            this.ServiceTypeSelector.Sorted = true;
            this.ServiceTypeSelector.TabIndex = 2;
            this.ServiceTypeSelector.SelectedIndexChanged += new System.EventHandler(this.ServiceTypeSelector_SelectedIndexChanged);
            // 
            // PlanSelector
            // 
            this.PlanSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlanSelector.FormattingEnabled = true;
            this.PlanSelector.Location = new System.Drawing.Point(208, 167);
            this.PlanSelector.Name = "PlanSelector";
            this.PlanSelector.Size = new System.Drawing.Size(552, 33);
            this.PlanSelector.Sorted = true;
            this.PlanSelector.TabIndex = 3;
            this.PlanSelector.SelectedIndexChanged += new System.EventHandler(this.PlanSelector_SelectedIndexChanged);
            // 
            // ServiceTypeText
            // 
            this.ServiceTypeText.AutoSize = true;
            this.ServiceTypeText.Location = new System.Drawing.Point(39, 120);
            this.ServiceTypeText.Name = "ServiceTypeText";
            this.ServiceTypeText.Size = new System.Drawing.Size(144, 25);
            this.ServiceTypeText.TabIndex = 4;
            this.ServiceTypeText.Text = "Service Type:";
            // 
            // ServicePlanLabel
            // 
            this.ServicePlanLabel.AutoSize = true;
            this.ServicePlanLabel.Location = new System.Drawing.Point(39, 167);
            this.ServicePlanLabel.Name = "ServicePlanLabel";
            this.ServicePlanLabel.Size = new System.Drawing.Size(61, 25);
            this.ServicePlanLabel.TabIndex = 5;
            this.ServicePlanLabel.Text = "Plan:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(334, 220);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 42);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Opslaan";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SongLocationLabel
            // 
            this.SongLocationLabel.AutoSize = true;
            this.SongLocationLabel.Location = new System.Drawing.Point(39, 73);
            this.SongLocationLabel.Name = "SongLocationLabel";
            this.SongLocationLabel.Size = new System.Drawing.Size(128, 25);
            this.SongLocationLabel.TabIndex = 7;
            this.SongLocationLabel.Text = "Lied locatie:";
            // 
            // EditSongLocation
            // 
            this.EditSongLocation.Location = new System.Drawing.Point(615, 68);
            this.EditSongLocation.Name = "EditSongLocation";
            this.EditSongLocation.Size = new System.Drawing.Size(145, 42);
            this.EditSongLocation.TabIndex = 8;
            this.EditSongLocation.Text = "Bewerken";
            this.EditSongLocation.UseVisualStyleBackColor = true;
            this.EditSongLocation.Click += new System.EventHandler(this.EditSongLocation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.EditSongLocation);
            this.Controls.Add(this.SongLocationLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ServicePlanLabel);
            this.Controls.Add(this.ServiceTypeText);
            this.Controls.Add(this.PlanSelector);
            this.Controls.Add(this.ServiceTypeSelector);
            this.Controls.Add(this.OrganisationName);
            this.Controls.Add(this.EditLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Planning center > OPS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditLogin;
        private System.Windows.Forms.Label OrganisationName;
        private System.Windows.Forms.ComboBox PlanSelector;
        private System.Windows.Forms.Label ServiceTypeText;
        private System.Windows.Forms.Label ServicePlanLabel;
        private System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.ComboBox ServiceTypeSelector;
        private System.Windows.Forms.Label SongLocationLabel;
        private System.Windows.Forms.Button EditSongLocation;
    }
}

