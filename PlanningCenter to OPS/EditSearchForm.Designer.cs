namespace PlanningCenter_to_OPS
{
    partial class EditSearchForm
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
            this.KinderCheckBox = new System.Windows.Forms.CheckBox();
            this.OpwekkingCheckBox = new System.Windows.Forms.CheckBox();
            this.OpwekkingQueryLabel = new System.Windows.Forms.Label();
            this.KinderOpwekkingLabel = new System.Windows.Forms.Label();
            this.OpwekkingLabel = new System.Windows.Forms.Label();
            this.KinderText = new System.Windows.Forms.TextBox();
            this.OpwekkingText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.MusicSelectInfo = new System.Windows.Forms.Label();
            this.OpwCaseSensitive = new System.Windows.Forms.CheckBox();
            this.KopwCaseSensitive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KinderCheckBox
            // 
            this.KinderCheckBox.AutoSize = true;
            this.KinderCheckBox.Location = new System.Drawing.Point(634, 162);
            this.KinderCheckBox.Name = "KinderCheckBox";
            this.KinderCheckBox.Size = new System.Drawing.Size(160, 29);
            this.KinderCheckBox.TabIndex = 25;
            this.KinderCheckBox.Text = "Geactiveerd";
            this.KinderCheckBox.UseVisualStyleBackColor = true;
            this.KinderCheckBox.CheckedChanged += new System.EventHandler(this.KinderCheckBox_CheckedChanged);
            // 
            // OpwekkingCheckBox
            // 
            this.OpwekkingCheckBox.AutoSize = true;
            this.OpwekkingCheckBox.Location = new System.Drawing.Point(634, 123);
            this.OpwekkingCheckBox.Name = "OpwekkingCheckBox";
            this.OpwekkingCheckBox.Size = new System.Drawing.Size(160, 29);
            this.OpwekkingCheckBox.TabIndex = 24;
            this.OpwekkingCheckBox.Text = "Geactiveerd";
            this.OpwekkingCheckBox.UseVisualStyleBackColor = true;
            this.OpwekkingCheckBox.CheckedChanged += new System.EventHandler(this.OpwekkingCheckBox_CheckedChanged);
            // 
            // OpwekkingQueryLabel
            // 
            this.OpwekkingQueryLabel.AutoSize = true;
            this.OpwekkingQueryLabel.Location = new System.Drawing.Point(30, 37);
            this.OpwekkingQueryLabel.Name = "OpwekkingQueryLabel";
            this.OpwekkingQueryLabel.Size = new System.Drawing.Size(875, 25);
            this.OpwekkingQueryLabel.TabIndex = 23;
            this.OpwekkingQueryLabel.Text = "Hier kunt u aanpassen wanneer een lied word herkend als een specifiek type binnen" +
    " OPS.";
            // 
            // KinderOpwekkingLabel
            // 
            this.KinderOpwekkingLabel.AutoSize = true;
            this.KinderOpwekkingLabel.Location = new System.Drawing.Point(30, 163);
            this.KinderOpwekkingLabel.Name = "KinderOpwekkingLabel";
            this.KinderOpwekkingLabel.Size = new System.Drawing.Size(182, 25);
            this.KinderOpwekkingLabel.TabIndex = 22;
            this.KinderOpwekkingLabel.Text = "Kinderopwekking:";
            // 
            // OpwekkingLabel
            // 
            this.OpwekkingLabel.AutoSize = true;
            this.OpwekkingLabel.Location = new System.Drawing.Point(30, 128);
            this.OpwekkingLabel.Name = "OpwekkingLabel";
            this.OpwekkingLabel.Size = new System.Drawing.Size(124, 25);
            this.OpwekkingLabel.TabIndex = 21;
            this.OpwekkingLabel.Text = "Opwekking:";
            // 
            // KinderText
            // 
            this.KinderText.Location = new System.Drawing.Point(218, 160);
            this.KinderText.Name = "KinderText";
            this.KinderText.Size = new System.Drawing.Size(403, 31);
            this.KinderText.TabIndex = 20;
            this.KinderText.TextChanged += new System.EventHandler(this.KinderText_TextChanged);
            // 
            // OpwekkingText
            // 
            this.OpwekkingText.Location = new System.Drawing.Point(218, 120);
            this.OpwekkingText.Name = "OpwekkingText";
            this.OpwekkingText.Size = new System.Drawing.Size(403, 31);
            this.OpwekkingText.TabIndex = 19;
            this.OpwekkingText.TextChanged += new System.EventHandler(this.OpwekkingText_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(435, 209);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(186, 52);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Annuleren";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(218, 209);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(188, 52);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Opslaan";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MusicSelectInfo
            // 
            this.MusicSelectInfo.AutoSize = true;
            this.MusicSelectInfo.Location = new System.Drawing.Point(30, 62);
            this.MusicSelectInfo.Name = "MusicSelectInfo";
            this.MusicSelectInfo.Size = new System.Drawing.Size(921, 25);
            this.MusicSelectInfo.TabIndex = 26;
            this.MusicSelectInfo.Text = "\"*\" betekent een of meerdere nummers, waarmee het lied geselecteerd word binnen h" +
    "et bundel.";
            // 
            // OpwCaseSensitive
            // 
            this.OpwCaseSensitive.AutoSize = true;
            this.OpwCaseSensitive.Location = new System.Drawing.Point(800, 123);
            this.OpwCaseSensitive.Name = "OpwCaseSensitive";
            this.OpwCaseSensitive.Size = new System.Drawing.Size(230, 29);
            this.OpwCaseSensitive.TabIndex = 27;
            this.OpwCaseSensitive.Text = "Hoofdlettergevoelig";
            this.OpwCaseSensitive.UseVisualStyleBackColor = true;
            this.OpwCaseSensitive.CheckedChanged += new System.EventHandler(this.OpwCaseSensitive_CheckedChanged);
            // 
            // KopwCaseSensitive
            // 
            this.KopwCaseSensitive.AutoSize = true;
            this.KopwCaseSensitive.Location = new System.Drawing.Point(800, 162);
            this.KopwCaseSensitive.Name = "KopwCaseSensitive";
            this.KopwCaseSensitive.Size = new System.Drawing.Size(230, 29);
            this.KopwCaseSensitive.TabIndex = 28;
            this.KopwCaseSensitive.Text = "Hoofdlettergevoelig";
            this.KopwCaseSensitive.UseVisualStyleBackColor = true;
            this.KopwCaseSensitive.CheckedChanged += new System.EventHandler(this.KopwCaseSensitive_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Het checked het begin van de tekst of het voorkomt.";
            // 
            // EditSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KopwCaseSensitive);
            this.Controls.Add(this.OpwCaseSensitive);
            this.Controls.Add(this.MusicSelectInfo);
            this.Controls.Add(this.KinderCheckBox);
            this.Controls.Add(this.OpwekkingCheckBox);
            this.Controls.Add(this.OpwekkingQueryLabel);
            this.Controls.Add(this.KinderOpwekkingLabel);
            this.Controls.Add(this.OpwekkingLabel);
            this.Controls.Add(this.KinderText);
            this.Controls.Add(this.OpwekkingText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Name = "EditSearchForm";
            this.Text = "Liedherkenning bewerken";
            this.Load += new System.EventHandler(this.EditSongSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox KinderCheckBox;
        private System.Windows.Forms.CheckBox OpwekkingCheckBox;
        private System.Windows.Forms.Label OpwekkingQueryLabel;
        private System.Windows.Forms.Label KinderOpwekkingLabel;
        private System.Windows.Forms.Label OpwekkingLabel;
        private System.Windows.Forms.TextBox KinderText;
        private System.Windows.Forms.TextBox OpwekkingText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label MusicSelectInfo;
        private System.Windows.Forms.CheckBox OpwCaseSensitive;
        private System.Windows.Forms.CheckBox KopwCaseSensitive;
        private System.Windows.Forms.Label label1;
    }
}