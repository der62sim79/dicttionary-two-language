namespace DictionaryTwoLanguage
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbGerman = new System.Windows.Forms.TextBox();
            this.tbEnglish = new System.Windows.Forms.TextBox();
            this.tbTurkish = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lBoxGermanWords = new System.Windows.Forms.ListBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbFindEN = new System.Windows.Forms.TextBox();
            this.tbFindTR = new System.Windows.Forms.TextBox();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGerman
            // 
            this.tbGerman.Location = new System.Drawing.Point(46, 42);
            this.tbGerman.Name = "tbGerman";
            this.tbGerman.Size = new System.Drawing.Size(275, 22);
            this.tbGerman.TabIndex = 0;
            this.tbGerman.Text = "...";
            // 
            // tbEnglish
            // 
            this.tbEnglish.Location = new System.Drawing.Point(403, 42);
            this.tbEnglish.Name = "tbEnglish";
            this.tbEnglish.Size = new System.Drawing.Size(241, 22);
            this.tbEnglish.TabIndex = 1;
            this.tbEnglish.Text = "...";
            // 
            // tbTurkish
            // 
            this.tbTurkish.Location = new System.Drawing.Point(737, 42);
            this.tbTurkish.Name = "tbTurkish";
            this.tbTurkish.Size = new System.Drawing.Size(243, 22);
            this.tbTurkish.TabIndex = 2;
            this.tbTurkish.Text = "...";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(314, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(380, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Übersetzng Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lBoxGermanWords
            // 
            this.lBoxGermanWords.FormattingEnabled = true;
            this.lBoxGermanWords.ItemHeight = 16;
            this.lBoxGermanWords.Location = new System.Drawing.Point(46, 347);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.Size = new System.Drawing.Size(495, 212);
            this.lBoxGermanWords.TabIndex = 4;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(46, 219);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(275, 22);
            this.tbSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(46, 274);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Suche";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbFindEN
            // 
            this.tbFindEN.Location = new System.Drawing.Point(616, 274);
            this.tbFindEN.Name = "tbFindEN";
            this.tbFindEN.Size = new System.Drawing.Size(333, 22);
            this.tbFindEN.TabIndex = 7;
            // 
            // tbFindTR
            // 
            this.tbFindTR.Location = new System.Drawing.Point(616, 399);
            this.tbFindTR.Name = "tbFindTR";
            this.tbFindTR.Size = new System.Drawing.Size(333, 22);
            this.tbFindTR.TabIndex = 8;
            this.tbFindTR.TextChanged += new System.EventHandler(this.tbFindTR_TextChanged);
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Location = new System.Drawing.Point(737, 530);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(162, 29);
            this.btnExportToCSV.TabIndex = 9;
            this.btnExportToCSV.Text = "ExportCSV";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Deutsches Wort ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Englisches Wort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Türkisches Wort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gesuchte Wort in Deutsch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "DE<>EN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "DE<>TR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 650);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportToCSV);
            this.Controls.Add(this.tbFindTR);
            this.Controls.Add(this.tbFindEN);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lBoxGermanWords);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbTurkish);
            this.Controls.Add(this.tbEnglish);
            this.Controls.Add(this.tbGerman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGerman;
        private System.Windows.Forms.TextBox tbEnglish;
        private System.Windows.Forms.TextBox tbTurkish;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lBoxGermanWords;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbFindEN;
        private System.Windows.Forms.TextBox tbFindTR;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

