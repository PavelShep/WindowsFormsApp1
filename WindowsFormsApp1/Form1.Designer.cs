namespace WindowsFormsApp1
{
    partial class Form1
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
            this.listBoxCountries = new System.Windows.Forms.ListBox();
            this.listBoxRegion = new System.Windows.Forms.ListBox();
            this.listBoxSubregion = new System.Windows.Forms.ListBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonCountry = new System.Windows.Forms.Button();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.labelOfficialName = new System.Windows.Forms.Label();
            this.labelCapital = new System.Windows.Forms.Label();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoatOfArms = new System.Windows.Forms.PictureBox();
            this.labelCapitalDateTime = new System.Windows.Forms.Label();
            this.labelCapitalTemperature = new System.Windows.Forms.Label();
            this.richTextBoxCurrencyInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoatOfArms)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCountries
            // 
            this.listBoxCountries.FormattingEnabled = true;
            this.listBoxCountries.Location = new System.Drawing.Point(3, 285);
            this.listBoxCountries.Name = "listBoxCountries";
            this.listBoxCountries.Size = new System.Drawing.Size(227, 108);
            this.listBoxCountries.TabIndex = 0;
            // 
            // listBoxRegion
            // 
            this.listBoxRegion.FormattingEnabled = true;
            this.listBoxRegion.Location = new System.Drawing.Point(12, 62);
            this.listBoxRegion.Name = "listBoxRegion";
            this.listBoxRegion.Size = new System.Drawing.Size(147, 69);
            this.listBoxRegion.TabIndex = 1;
            this.listBoxRegion.SelectedIndexChanged += new System.EventHandler(this.listBoxRegion_SelectedIndexChanged);
            // 
            // listBoxSubregion
            // 
            this.listBoxSubregion.FormattingEnabled = true;
            this.listBoxSubregion.Location = new System.Drawing.Point(12, 158);
            this.listBoxSubregion.Name = "listBoxSubregion";
            this.listBoxSubregion.Size = new System.Drawing.Size(147, 69);
            this.listBoxSubregion.TabIndex = 2;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 246);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(170, 23);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Wczytaj kraje z regiona";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(170, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Czytaj API";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonCountry
            // 
            this.buttonCountry.Location = new System.Drawing.Point(3, 415);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Size = new System.Drawing.Size(227, 23);
            this.buttonCountry.TabIndex = 5;
            this.buttonCountry.Text = "Wczytaj dane";
            this.buttonCountry.UseVisualStyleBackColor = true;
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click);
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Location = new System.Drawing.Point(326, 31);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(35, 13);
            this.labelCountryName.TabIndex = 6;
            this.labelCountryName.Text = "label1";
            // 
            // labelOfficialName
            // 
            this.labelOfficialName.AutoSize = true;
            this.labelOfficialName.Location = new System.Drawing.Point(326, 68);
            this.labelOfficialName.Name = "labelOfficialName";
            this.labelOfficialName.Size = new System.Drawing.Size(35, 13);
            this.labelOfficialName.TabIndex = 7;
            this.labelOfficialName.Text = "label2";
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(326, 109);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(39, 13);
            this.labelCapital.TabIndex = 8;
            this.labelCapital.Text = "Capital";
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Location = new System.Drawing.Point(518, 40);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxFlag.TabIndex = 9;
            this.pictureBoxFlag.TabStop = false;
            // 
            // pictureBoxCoatOfArms
            // 
            this.pictureBoxCoatOfArms.Location = new System.Drawing.Point(649, 40);
            this.pictureBoxCoatOfArms.Name = "pictureBoxCoatOfArms";
            this.pictureBoxCoatOfArms.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCoatOfArms.TabIndex = 10;
            this.pictureBoxCoatOfArms.TabStop = false;
            // 
            // labelCapitalDateTime
            // 
            this.labelCapitalDateTime.AutoSize = true;
            this.labelCapitalDateTime.Location = new System.Drawing.Point(329, 144);
            this.labelCapitalDateTime.Name = "labelCapitalDateTime";
            this.labelCapitalDateTime.Size = new System.Drawing.Size(94, 13);
            this.labelCapitalDateTime.TabIndex = 11;
            this.labelCapitalDateTime.Text = "labelDateAndTime";
            // 
            // labelCapitalTemperature
            // 
            this.labelCapitalTemperature.AutoSize = true;
            this.labelCapitalTemperature.Location = new System.Drawing.Point(329, 172);
            this.labelCapitalTemperature.Name = "labelCapitalTemperature";
            this.labelCapitalTemperature.Size = new System.Drawing.Size(62, 13);
            this.labelCapitalTemperature.TabIndex = 12;
            this.labelCapitalTemperature.Text = "label1Temp";
            // 
            // richTextBoxCurrencyInfo
            // 
            this.richTextBoxCurrencyInfo.Location = new System.Drawing.Point(384, 231);
            this.richTextBoxCurrencyInfo.Name = "richTextBoxCurrencyInfo";
            this.richTextBoxCurrencyInfo.Size = new System.Drawing.Size(261, 162);
            this.richTextBoxCurrencyInfo.TabIndex = 13;
            this.richTextBoxCurrencyInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxCurrencyInfo);
            this.Controls.Add(this.labelCapitalTemperature);
            this.Controls.Add(this.labelCapitalDateTime);
            this.Controls.Add(this.pictureBoxCoatOfArms);
            this.Controls.Add(this.pictureBoxFlag);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.labelOfficialName);
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.buttonCountry);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.listBoxSubregion);
            this.Controls.Add(this.listBoxRegion);
            this.Controls.Add(this.listBoxCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoatOfArms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCountries;
        private System.Windows.Forms.ListBox listBoxRegion;
        private System.Windows.Forms.ListBox listBoxSubregion;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCountry;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.Label labelOfficialName;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.PictureBox pictureBoxCoatOfArms;
        private System.Windows.Forms.Label labelCapitalDateTime;
        private System.Windows.Forms.Label labelCapitalTemperature;
        private System.Windows.Forms.RichTextBox richTextBoxCurrencyInfo;
    }
}

