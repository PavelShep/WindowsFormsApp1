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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.listBoxSubregion);
            this.Controls.Add(this.listBoxRegion);
            this.Controls.Add(this.listBoxCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCountries;
        private System.Windows.Forms.ListBox listBoxRegion;
        private System.Windows.Forms.ListBox listBoxSubregion;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button1;
    }
}

