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
            KinderCheckBox = new System.Windows.Forms.CheckBox();
            OpwekkingCheckBox = new System.Windows.Forms.CheckBox();
            OpwekkingQueryLabel = new System.Windows.Forms.Label();
            KinderOpwekkingLabel = new System.Windows.Forms.Label();
            OpwekkingLabel = new System.Windows.Forms.Label();
            KinderText = new System.Windows.Forms.TextBox();
            OpwekkingText = new System.Windows.Forms.TextBox();
            cancelButton = new System.Windows.Forms.Button();
            saveButton = new System.Windows.Forms.Button();
            MusicSelectInfo = new System.Windows.Forms.Label();
            OpwCaseSensitive = new System.Windows.Forms.CheckBox();
            KopwCaseSensitive = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // KinderCheckBox
            // 
            KinderCheckBox.AutoSize = true;
            KinderCheckBox.Location = new System.Drawing.Point(370, 101);
            KinderCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            KinderCheckBox.Name = "KinderCheckBox";
            KinderCheckBox.Size = new System.Drawing.Size(88, 19);
            KinderCheckBox.TabIndex = 25;
            KinderCheckBox.Text = "Geactiveerd";
            KinderCheckBox.UseVisualStyleBackColor = true;
            KinderCheckBox.CheckedChanged += KinderCheckBox_CheckedChanged;
            // 
            // OpwekkingCheckBox
            // 
            OpwekkingCheckBox.AutoSize = true;
            OpwekkingCheckBox.Location = new System.Drawing.Point(370, 73);
            OpwekkingCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            OpwekkingCheckBox.Name = "OpwekkingCheckBox";
            OpwekkingCheckBox.Size = new System.Drawing.Size(88, 19);
            OpwekkingCheckBox.TabIndex = 24;
            OpwekkingCheckBox.Text = "Geactiveerd";
            OpwekkingCheckBox.UseVisualStyleBackColor = true;
            OpwekkingCheckBox.CheckedChanged += OpwekkingCheckBox_CheckedChanged;
            // 
            // OpwekkingQueryLabel
            // 
            OpwekkingQueryLabel.AutoSize = true;
            OpwekkingQueryLabel.Location = new System.Drawing.Point(18, 20);
            OpwekkingQueryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            OpwekkingQueryLabel.Name = "OpwekkingQueryLabel";
            OpwekkingQueryLabel.Size = new System.Drawing.Size(474, 15);
            OpwekkingQueryLabel.TabIndex = 23;
            OpwekkingQueryLabel.Text = "Hier kunt u aanpassen wanneer een lied word herkend als een specifiek type binnen OPS.";
            // 
            // KinderOpwekkingLabel
            // 
            KinderOpwekkingLabel.AutoSize = true;
            KinderOpwekkingLabel.Location = new System.Drawing.Point(18, 102);
            KinderOpwekkingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            KinderOpwekkingLabel.Name = "KinderOpwekkingLabel";
            KinderOpwekkingLabel.Size = new System.Drawing.Size(102, 15);
            KinderOpwekkingLabel.TabIndex = 22;
            KinderOpwekkingLabel.Text = "Kinderopwekking:";
            // 
            // OpwekkingLabel
            // 
            OpwekkingLabel.AutoSize = true;
            OpwekkingLabel.Location = new System.Drawing.Point(18, 76);
            OpwekkingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            OpwekkingLabel.Name = "OpwekkingLabel";
            OpwekkingLabel.Size = new System.Drawing.Size(70, 15);
            OpwekkingLabel.TabIndex = 21;
            OpwekkingLabel.Text = "Opwekking:";
            // 
            // KinderText
            // 
            KinderText.Location = new System.Drawing.Point(127, 100);
            KinderText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            KinderText.Name = "KinderText";
            KinderText.Size = new System.Drawing.Size(237, 23);
            KinderText.TabIndex = 20;
            KinderText.TextChanged += KinderText_TextChanged;
            // 
            // OpwekkingText
            // 
            OpwekkingText.Location = new System.Drawing.Point(127, 71);
            OpwekkingText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            OpwekkingText.Name = "OpwekkingText";
            OpwekkingText.Size = new System.Drawing.Size(237, 23);
            OpwekkingText.TabIndex = 19;
            OpwekkingText.TextChanged += OpwekkingText_TextChanged;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(254, 129);
            cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(108, 31);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Annuleren";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(127, 129);
            saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(110, 31);
            saveButton.TabIndex = 17;
            saveButton.Text = "Opslaan";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // MusicSelectInfo
            // 
            MusicSelectInfo.AutoSize = true;
            MusicSelectInfo.Location = new System.Drawing.Point(18, 35);
            MusicSelectInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            MusicSelectInfo.Name = "MusicSelectInfo";
            MusicSelectInfo.Size = new System.Drawing.Size(512, 15);
            MusicSelectInfo.TabIndex = 26;
            MusicSelectInfo.Text = "\"*\" betekent een of meerdere nummers, waarmee het lied geselecteerd word binnen het bundel.";
            // 
            // OpwCaseSensitive
            // 
            OpwCaseSensitive.AutoSize = true;
            OpwCaseSensitive.Location = new System.Drawing.Point(467, 73);
            OpwCaseSensitive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            OpwCaseSensitive.Name = "OpwCaseSensitive";
            OpwCaseSensitive.Size = new System.Drawing.Size(132, 19);
            OpwCaseSensitive.TabIndex = 27;
            OpwCaseSensitive.Text = "Hoofdlettergevoelig";
            OpwCaseSensitive.UseVisualStyleBackColor = true;
            OpwCaseSensitive.CheckedChanged += OpwCaseSensitive_CheckedChanged;
            // 
            // KopwCaseSensitive
            // 
            KopwCaseSensitive.AutoSize = true;
            KopwCaseSensitive.Location = new System.Drawing.Point(467, 101);
            KopwCaseSensitive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            KopwCaseSensitive.Name = "KopwCaseSensitive";
            KopwCaseSensitive.Size = new System.Drawing.Size(132, 19);
            KopwCaseSensitive.TabIndex = 28;
            KopwCaseSensitive.Text = "Hoofdlettergevoelig";
            KopwCaseSensitive.UseVisualStyleBackColor = true;
            KopwCaseSensitive.CheckedChanged += KopwCaseSensitive_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 50);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(284, 15);
            label1.TabIndex = 29;
            label1.Text = "Het checked het begin van de tekst of het voorkomt.";
            // 
            // EditSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(610, 173);
            Controls.Add(label1);
            Controls.Add(KopwCaseSensitive);
            Controls.Add(OpwCaseSensitive);
            Controls.Add(MusicSelectInfo);
            Controls.Add(KinderCheckBox);
            Controls.Add(OpwekkingCheckBox);
            Controls.Add(OpwekkingQueryLabel);
            Controls.Add(KinderOpwekkingLabel);
            Controls.Add(OpwekkingLabel);
            Controls.Add(KinderText);
            Controls.Add(OpwekkingText);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "EditSearchForm";
            Text = "Liedherkenning bewerken";
            Load += EditSongSearch_Load;
            ResumeLayout(false);
            PerformLayout();
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