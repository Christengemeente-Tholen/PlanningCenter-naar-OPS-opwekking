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
            this.appIdTextBox = new System.Windows.Forms.TextBox();
            this.secretTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.apiLink = new System.Windows.Forms.LinkLabel();
            this.appIdLabel = new System.Windows.Forms.Label();
            this.secretIdLabel = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.titleLabel3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appIdTextBox
            // 
            this.appIdTextBox.Location = new System.Drawing.Point(213, 131);
            this.appIdTextBox.Name = "appIdTextBox";
            this.appIdTextBox.Size = new System.Drawing.Size(1027, 31);
            this.appIdTextBox.TabIndex = 0;
            this.appIdTextBox.TextChanged += new System.EventHandler(this.AppIdTextBox_TextChanged);
            // 
            // secretTextBox
            // 
            this.secretTextBox.Location = new System.Drawing.Point(213, 171);
            this.secretTextBox.Name = "secretTextBox";
            this.secretTextBox.Size = new System.Drawing.Size(1027, 31);
            this.secretTextBox.TabIndex = 1;
            this.secretTextBox.TextChanged += new System.EventHandler(this.SecretTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(40, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1043, 25);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Om dit progamma aan planningcenter te koppelen, moet er een personal access token" +
    " aangemaakt worden.";
            // 
            // apiLink
            // 
            this.apiLink.AutoSize = true;
            this.apiLink.Location = new System.Drawing.Point(368, 64);
            this.apiLink.Name = "apiLink";
            this.apiLink.Size = new System.Drawing.Size(539, 25);
            this.apiLink.TabIndex = 3;
            this.apiLink.TabStop = true;
            this.apiLink.Text = "https://api.planningcenteronline.com/oauth/applications";
            this.apiLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ApiLink_LinkClicked);
            // 
            // appIdLabel
            // 
            this.appIdLabel.AutoSize = true;
            this.appIdLabel.Location = new System.Drawing.Point(44, 136);
            this.appIdLabel.Name = "appIdLabel";
            this.appIdLabel.Size = new System.Drawing.Size(150, 25);
            this.appIdLabel.TabIndex = 4;
            this.appIdLabel.Text = "Application ID:";
            // 
            // secretIdLabel
            // 
            this.secretIdLabel.AutoSize = true;
            this.secretIdLabel.Location = new System.Drawing.Point(44, 171);
            this.secretIdLabel.Name = "secretIdLabel";
            this.secretIdLabel.Size = new System.Drawing.Size(80, 25);
            this.secretIdLabel.TabIndex = 5;
            this.secretIdLabel.Text = "Secret:";
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Location = new System.Drawing.Point(40, 64);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(321, 25);
            this.titleLabel2.TabIndex = 6;
            this.titleLabel2.Text = "Die kan aangemaakt worden op:";
            // 
            // titleLabel3
            // 
            this.titleLabel3.AutoSize = true;
            this.titleLabel3.Location = new System.Drawing.Point(40, 89);
            this.titleLabel3.Name = "titleLabel3";
            this.titleLabel3.Size = new System.Drawing.Size(1208, 25);
            this.titleLabel3.TabIndex = 7;
            this.titleLabel3.Text = "Vul na het aanmaken van een personal access token de application id en secret van" +
    " uw planningcenter account hieronder in:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(389, 218);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(188, 52);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Opslaan";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(743, 218);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(186, 52);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Annuleren";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SetAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1278, 296);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.titleLabel3);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.secretIdLabel);
            this.Controls.Add(this.appIdLabel);
            this.Controls.Add(this.apiLink);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.secretTextBox);
            this.Controls.Add(this.appIdTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetAuthForm";
            this.Text = "Api koppelen";
            this.Load += new System.EventHandler(this.SetAuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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