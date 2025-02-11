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
            EditLogin = new System.Windows.Forms.Button();
            OrganisationName = new System.Windows.Forms.Label();
            ServiceTypeSelector = new System.Windows.Forms.ComboBox();
            PlanSelector = new System.Windows.Forms.ComboBox();
            ServiceTypeText = new System.Windows.Forms.Label();
            ServicePlanLabel = new System.Windows.Forms.Label();
            SaveButton = new System.Windows.Forms.Button();
            SongLocationLabel = new System.Windows.Forms.Label();
            EditSongLocation = new System.Windows.Forms.Button();
            EditOpsSkipList = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ReadSongs = new System.Windows.Forms.Button();
            OpsThemeSelector = new System.Windows.Forms.ComboBox();
            OPSThemeLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // EditLogin
            // 
            EditLogin.Location = new System.Drawing.Point(628, 26);
            EditLogin.Margin = new System.Windows.Forms.Padding(4);
            EditLogin.Name = "EditLogin";
            EditLogin.Size = new System.Drawing.Size(144, 50);
            EditLogin.TabIndex = 0;
            EditLogin.Text = "Bewerken";
            EditLogin.UseVisualStyleBackColor = true;
            EditLogin.Click += EditLogin_Click;
            // 
            // OrganisationName
            // 
            OrganisationName.AutoSize = true;
            OrganisationName.Location = new System.Drawing.Point(34, 36);
            OrganisationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OrganisationName.Name = "OrganisationName";
            OrganisationName.Size = new System.Drawing.Size(187, 32);
            OrganisationName.TabIndex = 1;
            OrganisationName.Text = "Gekoppeld aan: ";
            // 
            // ServiceTypeSelector
            // 
            ServiceTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ServiceTypeSelector.FormattingEnabled = true;
            ServiceTypeSelector.Location = new System.Drawing.Point(202, 138);
            ServiceTypeSelector.Margin = new System.Windows.Forms.Padding(4);
            ServiceTypeSelector.Name = "ServiceTypeSelector";
            ServiceTypeSelector.Size = new System.Drawing.Size(566, 40);
            ServiceTypeSelector.TabIndex = 2;
            ServiceTypeSelector.SelectedIndexChanged += ServiceTypeSelector_SelectedIndexChanged;
            // 
            // PlanSelector
            // 
            PlanSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            PlanSelector.FormattingEnabled = true;
            PlanSelector.Location = new System.Drawing.Point(202, 194);
            PlanSelector.Margin = new System.Windows.Forms.Padding(4);
            PlanSelector.Name = "PlanSelector";
            PlanSelector.Size = new System.Drawing.Size(566, 40);
            PlanSelector.TabIndex = 3;
            PlanSelector.SelectedIndexChanged += PlanSelector_SelectedIndexChanged;
            // 
            // ServiceTypeText
            // 
            ServiceTypeText.AutoSize = true;
            ServiceTypeText.Location = new System.Drawing.Point(34, 142);
            ServiceTypeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ServiceTypeText.Name = "ServiceTypeText";
            ServiceTypeText.Size = new System.Drawing.Size(153, 32);
            ServiceTypeText.TabIndex = 4;
            ServiceTypeText.Text = "Service Type:";
            // 
            // ServicePlanLabel
            // 
            ServicePlanLabel.AutoSize = true;
            ServicePlanLabel.Location = new System.Drawing.Point(34, 200);
            ServicePlanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ServicePlanLabel.Name = "ServicePlanLabel";
            ServicePlanLabel.Size = new System.Drawing.Size(64, 32);
            ServicePlanLabel.TabIndex = 5;
            ServicePlanLabel.Text = "Plan:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(38, 364);
            SaveButton.Margin = new System.Windows.Forms.Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(734, 50);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Opslaan";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SongLocationLabel
            // 
            SongLocationLabel.AutoSize = true;
            SongLocationLabel.Location = new System.Drawing.Point(34, 86);
            SongLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SongLocationLabel.Name = "SongLocationLabel";
            SongLocationLabel.Size = new System.Drawing.Size(140, 32);
            SongLocationLabel.TabIndex = 7;
            SongLocationLabel.Text = "Lied locatie:";
            // 
            // EditSongLocation
            // 
            EditSongLocation.Location = new System.Drawing.Point(628, 80);
            EditSongLocation.Margin = new System.Windows.Forms.Padding(4);
            EditSongLocation.Name = "EditSongLocation";
            EditSongLocation.Size = new System.Drawing.Size(144, 50);
            EditSongLocation.TabIndex = 8;
            EditSongLocation.Text = "Bewerken";
            EditSongLocation.UseVisualStyleBackColor = true;
            EditSongLocation.Click += EditSongLocation_Click;
            // 
            // EditOpsSkipList
            // 
            EditOpsSkipList.Location = new System.Drawing.Point(250, 304);
            EditOpsSkipList.Margin = new System.Windows.Forms.Padding(4);
            EditOpsSkipList.Name = "EditOpsSkipList";
            EditOpsSkipList.Size = new System.Drawing.Size(270, 50);
            EditOpsSkipList.TabIndex = 9;
            EditOpsSkipList.Text = "OPS Skiplist bewerken";
            EditOpsSkipList.UseVisualStyleBackColor = true;
            EditOpsSkipList.Click += EditOpsSkipList_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(38, 304);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(204, 50);
            button1.TabIndex = 10;
            button1.Text = "Liedherkenning";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReadSongs
            // 
            ReadSongs.Location = new System.Drawing.Point(528, 304);
            ReadSongs.Margin = new System.Windows.Forms.Padding(4);
            ReadSongs.Name = "ReadSongs";
            ReadSongs.Size = new System.Drawing.Size(244, 50);
            ReadSongs.TabIndex = 11;
            ReadSongs.Text = "Liedtitels exporteren";
            ReadSongs.UseVisualStyleBackColor = true;
            ReadSongs.Click += ReadSongs_Click;
            // 
            // OpsThemeSelector
            // 
            OpsThemeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            OpsThemeSelector.FormattingEnabled = true;
            OpsThemeSelector.Location = new System.Drawing.Point(202, 250);
            OpsThemeSelector.Margin = new System.Windows.Forms.Padding(4);
            OpsThemeSelector.Name = "OpsThemeSelector";
            OpsThemeSelector.Size = new System.Drawing.Size(566, 40);
            OpsThemeSelector.Sorted = true;
            OpsThemeSelector.TabIndex = 12;
            OpsThemeSelector.SelectedIndexChanged += OpsThemeSelector_SelectedIndexChanged;
            // 
            // OPSThemeLabel
            // 
            OPSThemeLabel.AutoSize = true;
            OPSThemeLabel.Location = new System.Drawing.Point(38, 258);
            OPSThemeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OPSThemeLabel.Name = "OPSThemeLabel";
            OPSThemeLabel.Size = new System.Drawing.Size(143, 32);
            OPSThemeLabel.TabIndex = 13;
            OPSThemeLabel.Text = "OPS Thema:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(808, 448);
            Controls.Add(OPSThemeLabel);
            Controls.Add(OpsThemeSelector);
            Controls.Add(ReadSongs);
            Controls.Add(button1);
            Controls.Add(EditOpsSkipList);
            Controls.Add(EditSongLocation);
            Controls.Add(SongLocationLabel);
            Controls.Add(SaveButton);
            Controls.Add(ServicePlanLabel);
            Controls.Add(ServiceTypeText);
            Controls.Add(PlanSelector);
            Controls.Add(ServiceTypeSelector);
            Controls.Add(OrganisationName);
            Controls.Add(EditLogin);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Planning center > OPS";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button EditOpsSkipList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReadSongs;
        private System.Windows.Forms.ComboBox OpsThemeSelector;
        private System.Windows.Forms.Label OPSThemeLabel;
    }
}

