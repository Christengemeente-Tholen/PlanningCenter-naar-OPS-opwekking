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
            KinderCheckBox.Location = new System.Drawing.Point(687, 215);
            KinderCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            KinderCheckBox.Name = "KinderCheckBox";
            KinderCheckBox.Size = new System.Drawing.Size(172, 36);
            KinderCheckBox.TabIndex = 25;
            KinderCheckBox.Text = "Geactiveerd";
            KinderCheckBox.UseVisualStyleBackColor = true;
            KinderCheckBox.CheckedChanged += KinderCheckBox_CheckedChanged;
            // 
            // OpwekkingCheckBox
            // 
            OpwekkingCheckBox.AutoSize = true;
            OpwekkingCheckBox.Location = new System.Drawing.Point(687, 156);
            OpwekkingCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            OpwekkingCheckBox.Name = "OpwekkingCheckBox";
            OpwekkingCheckBox.Size = new System.Drawing.Size(172, 36);
            OpwekkingCheckBox.TabIndex = 24;
            OpwekkingCheckBox.Text = "Geactiveerd";
            OpwekkingCheckBox.UseVisualStyleBackColor = true;
            OpwekkingCheckBox.CheckedChanged += OpwekkingCheckBox_CheckedChanged;
            // 
            // OpwekkingQueryLabel
            // 
            OpwekkingQueryLabel.AutoSize = true;
            OpwekkingQueryLabel.Location = new System.Drawing.Point(33, 43);
            OpwekkingQueryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OpwekkingQueryLabel.Name = "OpwekkingQueryLabel";
            OpwekkingQueryLabel.Size = new System.Drawing.Size(972, 32);
            OpwekkingQueryLabel.TabIndex = 23;
            OpwekkingQueryLabel.Text = "Hier kunt u aanpassen wanneer een lied word herkend als een specifiek type binnen OPS.";
            // 
            // KinderOpwekkingLabel
            // 
            KinderOpwekkingLabel.AutoSize = true;
            KinderOpwekkingLabel.Location = new System.Drawing.Point(33, 218);
            KinderOpwekkingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            KinderOpwekkingLabel.Name = "KinderOpwekkingLabel";
            KinderOpwekkingLabel.Size = new System.Drawing.Size(204, 32);
            KinderOpwekkingLabel.TabIndex = 22;
            KinderOpwekkingLabel.Text = "Kinderopwekking:";
            // 
            // OpwekkingLabel
            // 
            OpwekkingLabel.AutoSize = true;
            OpwekkingLabel.Location = new System.Drawing.Point(33, 160);
            OpwekkingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OpwekkingLabel.Name = "OpwekkingLabel";
            OpwekkingLabel.Size = new System.Drawing.Size(139, 32);
            OpwekkingLabel.TabIndex = 21;
            OpwekkingLabel.Text = "Opwekking:";
            // 
            // KinderText
            // 
            KinderText.Location = new System.Drawing.Point(236, 213);
            KinderText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            KinderText.Name = "KinderText";
            KinderText.Size = new System.Drawing.Size(437, 39);
            KinderText.TabIndex = 20;
            KinderText.TextChanged += KinderText_TextChanged;
            // 
            // OpwekkingText
            // 
            OpwekkingText.Location = new System.Drawing.Point(236, 151);
            OpwekkingText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            OpwekkingText.Name = "OpwekkingText";
            OpwekkingText.Size = new System.Drawing.Size(437, 39);
            OpwekkingText.TabIndex = 19;
            OpwekkingText.TextChanged += OpwekkingText_TextChanged;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(475, 395);
            cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(201, 66);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Annuleren";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(240, 395);
            saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(204, 66);
            saveButton.TabIndex = 17;
            saveButton.Text = "Opslaan";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // MusicSelectInfo
            // 
            MusicSelectInfo.AutoSize = true;
            MusicSelectInfo.Location = new System.Drawing.Point(33, 75);
            MusicSelectInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MusicSelectInfo.Name = "MusicSelectInfo";
            MusicSelectInfo.Size = new System.Drawing.Size(1048, 32);
            MusicSelectInfo.TabIndex = 26;
            MusicSelectInfo.Text = "\"*\" betekent een of meerdere nummers, waarmee het lied geselecteerd word binnen het bundel.";
            // 
            // OpwCaseSensitive
            // 
            OpwCaseSensitive.AutoSize = true;
            OpwCaseSensitive.Location = new System.Drawing.Point(867, 158);
            OpwCaseSensitive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            OpwCaseSensitive.Name = "OpwCaseSensitive";
            OpwCaseSensitive.Size = new System.Drawing.Size(261, 36);
            OpwCaseSensitive.TabIndex = 27;
            OpwCaseSensitive.Text = "Hoofdlettergevoelig";
            OpwCaseSensitive.UseVisualStyleBackColor = true;
            OpwCaseSensitive.CheckedChanged += OpwCaseSensitive_CheckedChanged;
            // 
            // KopwCaseSensitive
            // 
            KopwCaseSensitive.AutoSize = true;
            KopwCaseSensitive.Location = new System.Drawing.Point(867, 218);
            KopwCaseSensitive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            KopwCaseSensitive.Name = "KopwCaseSensitive";
            KopwCaseSensitive.Size = new System.Drawing.Size(261, 36);
            KopwCaseSensitive.TabIndex = 28;
            KopwCaseSensitive.Text = "Hoofdlettergevoelig";
            KopwCaseSensitive.UseVisualStyleBackColor = true;
            KopwCaseSensitive.CheckedChanged += KopwCaseSensitive_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 107);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(580, 32);
            label1.TabIndex = 29;
            label1.Text = "Het checked het begin van de tekst of het voorkomt.";
            // 
            // EigenTekstLabel
            // 
            EigenTekstLabel.AutoSize = true;
            EigenTekstLabel.Location = new System.Drawing.Point(33, 282);
            EigenTekstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            EigenTekstLabel.Name = "EigenTekstLabel";
            EigenTekstLabel.Size = new System.Drawing.Size(815, 32);
            EigenTekstLabel.TabIndex = 30;
            EigenTekstLabel.Text = "Hier kunt u aanpassen welke bibliotheek gebruikt word voor eigen teksten.";
            // 
            // AfkortingLabel
            // 
            AfkortingLabel.AutoSize = true;
            AfkortingLabel.Location = new System.Drawing.Point(35, 335);
            AfkortingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AfkortingLabel.Name = "AfkortingLabel";
            AfkortingLabel.Size = new System.Drawing.Size(118, 32);
            AfkortingLabel.TabIndex = 32;
            AfkortingLabel.Text = "Afkorting:";
            // 
            // ETAfkortingTextBox
            // 
            ETAfkortingTextBox.Location = new System.Drawing.Point(154, 329);
            ETAfkortingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ETAfkortingTextBox.Name = "ETAfkortingTextBox";
            ETAfkortingTextBox.Size = new System.Drawing.Size(188, 39);
            ETAfkortingTextBox.TabIndex = 31;
            ETAfkortingTextBox.TextChanged += ETAfkortingTextBox_TextChanged;
            // 
            // BundelLabel
            // 
            BundelLabel.AutoSize = true;
            BundelLabel.Location = new System.Drawing.Point(362, 335);
            BundelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BundelLabel.Name = "BundelLabel";
            BundelLabel.Size = new System.Drawing.Size(153, 32);
            BundelLabel.TabIndex = 34;
            BundelLabel.Text = "Bundelnaam:";
            // 
            // ETBundelTextBox
            // 
            ETBundelTextBox.Location = new System.Drawing.Point(513, 326);
            ETBundelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ETBundelTextBox.Name = "ETBundelTextBox";
            ETBundelTextBox.Size = new System.Drawing.Size(416, 39);
            ETBundelTextBox.TabIndex = 33;
            ETBundelTextBox.TextChanged += ETBundelTextBox_TextChanged;
            // 
            // ETCheckBox
            // 
            ETCheckBox.AutoSize = true;
            ETCheckBox.Location = new System.Drawing.Point(947, 331);
            ETCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ETCheckBox.Name = "ETCheckBox";
            ETCheckBox.Size = new System.Drawing.Size(172, 36);
            ETCheckBox.TabIndex = 35;
            ETCheckBox.Text = "Geactiveerd";
            ETCheckBox.UseVisualStyleBackColor = true;
            ETCheckBox.CheckedChanged += ETCheckBox_CheckedChanged;
            // 
            // EditSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1133, 484);
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
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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