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
            EigenTekstLabel = new System.Windows.Forms.Label();
            AfkortingLabel = new System.Windows.Forms.Label();
            ETAfkortingTextBox = new System.Windows.Forms.TextBox();
            BundelLabel = new System.Windows.Forms.Label();
            ETBundelTextBox = new System.Windows.Forms.TextBox();
            ETCheckBox = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // KinderCheckBox
            // 
            KinderCheckBox.AutoSize = true;
            KinderCheckBox.Location = new System.Drawing.Point(370, 101);
            KinderCheckBox.Margin = new System.Windows.Forms.Padding(2);
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
            OpwekkingCheckBox.Margin = new System.Windows.Forms.Padding(2);
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
            OpwekkingLabel.Location = new System.Drawing.Point(18, 75);
            OpwekkingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            OpwekkingLabel.Name = "OpwekkingLabel";
            OpwekkingLabel.Size = new System.Drawing.Size(70, 15);
            OpwekkingLabel.TabIndex = 21;
            OpwekkingLabel.Text = "Opwekking:";
            // 
            // KinderText
            // 
            KinderText.Location = new System.Drawing.Point(127, 100);
            KinderText.Margin = new System.Windows.Forms.Padding(2);
            KinderText.Name = "KinderText";
            KinderText.Size = new System.Drawing.Size(237, 23);
            KinderText.TabIndex = 20;
            KinderText.TextChanged += KinderText_TextChanged;
            // 
            // OpwekkingText
            // 
            OpwekkingText.Location = new System.Drawing.Point(127, 71);
            OpwekkingText.Margin = new System.Windows.Forms.Padding(2);
            OpwekkingText.Name = "OpwekkingText";
            OpwekkingText.Size = new System.Drawing.Size(237, 23);
            OpwekkingText.TabIndex = 19;
            OpwekkingText.TextChanged += OpwekkingText_TextChanged;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(256, 185);
            cancelButton.Margin = new System.Windows.Forms.Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(108, 31);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Annuleren";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(129, 185);
            saveButton.Margin = new System.Windows.Forms.Padding(2);
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
            OpwCaseSensitive.Location = new System.Drawing.Point(467, 74);
            OpwCaseSensitive.Margin = new System.Windows.Forms.Padding(2);
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
            KopwCaseSensitive.Location = new System.Drawing.Point(467, 102);
            KopwCaseSensitive.Margin = new System.Windows.Forms.Padding(2);
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
            // EigenTekstLabel
            // 
            EigenTekstLabel.AutoSize = true;
            EigenTekstLabel.Location = new System.Drawing.Point(18, 132);
            EigenTekstLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            EigenTekstLabel.Name = "EigenTekstLabel";
            EigenTekstLabel.Size = new System.Drawing.Size(399, 15);
            EigenTekstLabel.TabIndex = 30;
            EigenTekstLabel.Text = "Hier kunt u aanpassen welke bibliotheek gebruikt word voor eigen teksten.";
            // 
            // AfkortingLabel
            // 
            AfkortingLabel.AutoSize = true;
            AfkortingLabel.Location = new System.Drawing.Point(19, 157);
            AfkortingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            AfkortingLabel.Name = "AfkortingLabel";
            AfkortingLabel.Size = new System.Drawing.Size(60, 15);
            AfkortingLabel.TabIndex = 32;
            AfkortingLabel.Text = "Afkorting:";
            // 
            // ETAfkortingTextBox
            // 
            ETAfkortingTextBox.Location = new System.Drawing.Point(83, 154);
            ETAfkortingTextBox.Margin = new System.Windows.Forms.Padding(2);
            ETAfkortingTextBox.Name = "ETAfkortingTextBox";
            ETAfkortingTextBox.Size = new System.Drawing.Size(103, 23);
            ETAfkortingTextBox.TabIndex = 31;
            ETAfkortingTextBox.TextChanged += ETAfkortingTextBox_TextChanged;
            // 
            // BundelLabel
            // 
            BundelLabel.AutoSize = true;
            BundelLabel.Location = new System.Drawing.Point(195, 157);
            BundelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            BundelLabel.Name = "BundelLabel";
            BundelLabel.Size = new System.Drawing.Size(77, 15);
            BundelLabel.TabIndex = 34;
            BundelLabel.Text = "Bundelnaam:";
            // 
            // ETBundelTextBox
            // 
            ETBundelTextBox.Location = new System.Drawing.Point(276, 153);
            ETBundelTextBox.Margin = new System.Windows.Forms.Padding(2);
            ETBundelTextBox.Name = "ETBundelTextBox";
            ETBundelTextBox.Size = new System.Drawing.Size(226, 23);
            ETBundelTextBox.TabIndex = 33;
            ETBundelTextBox.TextChanged += ETBundelTextBox_TextChanged;
            // 
            // ETCheckBox
            // 
            ETCheckBox.AutoSize = true;
            ETCheckBox.Location = new System.Drawing.Point(510, 155);
            ETCheckBox.Margin = new System.Windows.Forms.Padding(2);
            ETCheckBox.Name = "ETCheckBox";
            ETCheckBox.Size = new System.Drawing.Size(88, 19);
            ETCheckBox.TabIndex = 35;
            ETCheckBox.Text = "Geactiveerd";
            ETCheckBox.UseVisualStyleBackColor = true;
            ETCheckBox.CheckedChanged += ETCheckBox_CheckedChanged;
            // 
            // EditSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(610, 227);
            Controls.Add(ETCheckBox);
            Controls.Add(BundelLabel);
            Controls.Add(ETBundelTextBox);
            Controls.Add(AfkortingLabel);
            Controls.Add(ETAfkortingTextBox);
            Controls.Add(EigenTekstLabel);
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
            Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label EigenTekstLabel;
        private System.Windows.Forms.Label AfkortingLabel;
        private System.Windows.Forms.TextBox ETAfkortingTextBox;
        private System.Windows.Forms.Label BundelLabel;
        private System.Windows.Forms.TextBox ETBundelTextBox;
        private System.Windows.Forms.CheckBox ETCheckBox;
    }
}