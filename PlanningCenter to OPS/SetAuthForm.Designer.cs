namespace PlanningCenter_to_OPS
{
    partial class SetAuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetAuthForm));
            appIdTextBox = new System.Windows.Forms.TextBox();
            secretTextBox = new System.Windows.Forms.TextBox();
            titleLabel = new System.Windows.Forms.Label();
            apiLink = new System.Windows.Forms.LinkLabel();
            appIdLabel = new System.Windows.Forms.Label();
            secretIdLabel = new System.Windows.Forms.Label();
            titleLabel2 = new System.Windows.Forms.Label();
            titleLabel3 = new System.Windows.Forms.Label();
            saveButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // appIdTextBox
            // 
            appIdTextBox.Location = new System.Drawing.Point(106, 64);
            appIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            appIdTextBox.Name = "appIdTextBox";
            appIdTextBox.Size = new System.Drawing.Size(588, 23);
            appIdTextBox.TabIndex = 0;
            appIdTextBox.TextChanged += AppIdTextBox_TextChanged;
            // 
            // secretTextBox
            // 
            secretTextBox.Location = new System.Drawing.Point(106, 93);
            secretTextBox.Margin = new System.Windows.Forms.Padding(2);
            secretTextBox.Name = "secretTextBox";
            secretTextBox.Size = new System.Drawing.Size(588, 23);
            secretTextBox.TabIndex = 1;
            secretTextBox.TextChanged += SecretTextBox_TextChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(20, 12);
            titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(577, 15);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Om dit progamma aan planningcenter te koppelen, moet er een personal access token aangemaakt worden.";
            // 
            // apiLink
            // 
            apiLink.AutoSize = true;
            apiLink.Location = new System.Drawing.Point(196, 28);
            apiLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            apiLink.Name = "apiLink";
            apiLink.Size = new System.Drawing.Size(311, 15);
            apiLink.TabIndex = 3;
            apiLink.TabStop = true;
            apiLink.Text = "https://api.planningcenteronline.com/oauth/applications";
            apiLink.LinkClicked += ApiLink_LinkClicked;
            // 
            // appIdLabel
            // 
            appIdLabel.AutoSize = true;
            appIdLabel.Location = new System.Drawing.Point(22, 67);
            appIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            appIdLabel.Name = "appIdLabel";
            appIdLabel.Size = new System.Drawing.Size(85, 15);
            appIdLabel.TabIndex = 4;
            appIdLabel.Text = "Application ID:";
            // 
            // secretIdLabel
            // 
            secretIdLabel.AutoSize = true;
            secretIdLabel.Location = new System.Drawing.Point(22, 96);
            secretIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            secretIdLabel.Name = "secretIdLabel";
            secretIdLabel.Size = new System.Drawing.Size(42, 15);
            secretIdLabel.TabIndex = 5;
            secretIdLabel.Text = "Secret:";
            // 
            // titleLabel2
            // 
            titleLabel2.AutoSize = true;
            titleLabel2.Location = new System.Drawing.Point(20, 28);
            titleLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            titleLabel2.Name = "titleLabel2";
            titleLabel2.Size = new System.Drawing.Size(177, 15);
            titleLabel2.TabIndex = 6;
            titleLabel2.Text = "Die kan aangemaakt worden op:";
            // 
            // titleLabel3
            // 
            titleLabel3.AutoSize = true;
            titleLabel3.Location = new System.Drawing.Point(20, 44);
            titleLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            titleLabel3.Name = "titleLabel3";
            titleLabel3.Size = new System.Drawing.Size(661, 15);
            titleLabel3.TabIndex = 7;
            titleLabel3.Text = "Vul na het aanmaken van een personal access token de application id en secret van uw planningcenter account hieronder in:";
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(218, 123);
            saveButton.Margin = new System.Windows.Forms.Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(94, 26);
            saveButton.TabIndex = 8;
            saveButton.Text = "Opslaan";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(394, 122);
            cancelButton.Margin = new System.Windows.Forms.Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(93, 26);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Annuleren";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // SetAuthForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(708, 161);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(titleLabel3);
            Controls.Add(titleLabel2);
            Controls.Add(secretIdLabel);
            Controls.Add(appIdLabel);
            Controls.Add(apiLink);
            Controls.Add(titleLabel);
            Controls.Add(secretTextBox);
            Controls.Add(appIdTextBox);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            Name = "SetAuthForm";
            Text = "Api koppelen";
            Load += SetAuthForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox appIdTextBox;
        private System.Windows.Forms.TextBox secretTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.LinkLabel apiLink;
        private System.Windows.Forms.Label appIdLabel;
        private System.Windows.Forms.Label secretIdLabel;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label titleLabel3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}