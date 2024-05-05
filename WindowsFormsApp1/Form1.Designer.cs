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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoatOfArms)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCountries
            // 
            this.listBoxCountries.FormattingEnabled = true;
            this.listBoxCountries.Location = new System.Drawing.Point(12, 301);
            this.listBoxCountries.Name = "listBoxCountries";
            this.listBoxCountries.Size = new System.Drawing.Size(218, 95);
            this.listBoxCountries.TabIndex = 0;
            // 
            // listBoxRegion
            // 
            this.listBoxRegion.FormattingEnabled = true;
            this.listBoxRegion.Location = new System.Drawing.Point(12, 71);
            this.listBoxRegion.Name = "listBoxRegion";
            this.listBoxRegion.Size = new System.Drawing.Size(147, 69);
            this.listBoxRegion.TabIndex = 1;
            this.listBoxRegion.SelectedIndexChanged += new System.EventHandler(this.listBoxRegion_SelectedIndexChanged);
            // 
            // listBoxSubregion
            // 
            this.listBoxSubregion.FormattingEnabled = true;
            this.listBoxSubregion.Location = new System.Drawing.Point(12, 173);
            this.listBoxSubregion.Name = "listBoxSubregion";
            this.listBoxSubregion.Size = new System.Drawing.Size(147, 69);
            this.listBoxSubregion.TabIndex = 2;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 260);
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
            this.buttonCountry.Location = new System.Drawing.Point(12, 415);
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
            this.labelCountryName.Location = new System.Drawing.Point(325, 34);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(93, 13);
            this.labelCountryName.TabIndex = 6;
            this.labelCountryName.Text = "labelCountryName";
            // 
            // labelOfficialName
            // 
            this.labelOfficialName.AutoSize = true;
            this.labelOfficialName.Location = new System.Drawing.Point(324, 80);
            this.labelOfficialName.Name = "labelOfficialName";
            this.labelOfficialName.Size = new System.Drawing.Size(89, 13);
            this.labelOfficialName.TabIndex = 7;
            this.labelOfficialName.Text = "labelOfficialName";
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(324, 121);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(61, 13);
            this.labelCapital.TabIndex = 8;
            this.labelCapital.Text = "labelCapital";
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Location = new System.Drawing.Point(529, 90);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxFlag.TabIndex = 9;
            this.pictureBoxFlag.TabStop = false;
            // 
            // pictureBoxCoatOfArms
            // 
            this.pictureBoxCoatOfArms.Location = new System.Drawing.Point(684, 90);
            this.pictureBoxCoatOfArms.Name = "pictureBoxCoatOfArms";
            this.pictureBoxCoatOfArms.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCoatOfArms.TabIndex = 10;
            this.pictureBoxCoatOfArms.TabStop = false;
            // 
            // labelCapitalDateTime
            // 
            this.labelCapitalDateTime.AutoSize = true;
            this.labelCapitalDateTime.Location = new System.Drawing.Point(324, 159);
            this.labelCapitalDateTime.Name = "labelCapitalDateTime";
            this.labelCapitalDateTime.Size = new System.Drawing.Size(94, 13);
            this.labelCapitalDateTime.TabIndex = 11;
            this.labelCapitalDateTime.Text = "labelDateAndTime";
            // 
            // labelCapitalTemperature
            // 
            this.labelCapitalTemperature.AutoSize = true;
            this.labelCapitalTemperature.Location = new System.Drawing.Point(324, 203);
            this.labelCapitalTemperature.Name = "labelCapitalTemperature";
            this.labelCapitalTemperature.Size = new System.Drawing.Size(89, 13);
            this.labelCapitalTemperature.TabIndex = 12;
            this.labelCapitalTemperature.Text = "labelTemperature";
            // 
            // richTextBoxCurrencyInfo
            // 
            this.richTextBoxCurrencyInfo.Location = new System.Drawing.Point(406, 260);
            this.richTextBoxCurrencyInfo.Name = "richTextBoxCurrencyInfo";
            this.richTextBoxCurrencyInfo.ReadOnly = true;
            this.richTextBoxCurrencyInfo.Size = new System.Drawing.Size(261, 162);
            this.richTextBoxCurrencyInfo.TabIndex = 13;
            this.richTextBoxCurrencyInfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Country Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(324, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Official Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(324, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Capital:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(526, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Flaga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(681, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Godło:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(9, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Region:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Subregion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(324, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date and Time in Capital:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(324, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Temperature in Capital:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(506, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Waluta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

