namespace SemestralniPrace
{
    partial class Main
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
            this.LVknihy = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LVzakaznici = new System.Windows.Forms.ListView();
            this.surrColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loanColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.LVoddeleni = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LVvypujc = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LVknihy
            // 
            this.LVknihy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LVknihy.HideSelection = false;
            this.LVknihy.Location = new System.Drawing.Point(264, 28);
            this.LVknihy.Name = "LVknihy";
            this.LVknihy.Size = new System.Drawing.Size(252, 464);
            this.LVknihy.TabIndex = 0;
            this.LVknihy.UseCompatibleStateImageBehavior = false;
            this.LVknihy.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Název";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Autor";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ISBN";
            this.columnHeader4.Width = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oddělení";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Knihy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zákazníci";
            // 
            // LVzakaznici
            // 
            this.LVzakaznici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.surrColumn,
            this.idColumn,
            this.loanColumn});
            this.LVzakaznici.HideSelection = false;
            this.LVzakaznici.Location = new System.Drawing.Point(522, 28);
            this.LVzakaznici.Name = "LVzakaznici";
            this.LVzakaznici.Size = new System.Drawing.Size(252, 464);
            this.LVzakaznici.TabIndex = 5;
            this.LVzakaznici.UseCompatibleStateImageBehavior = false;
            this.LVzakaznici.View = System.Windows.Forms.View.Details;
            this.LVzakaznici.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zakActive);
            // 
            // surrColumn
            // 
            this.surrColumn.DisplayIndex = 1;
            this.surrColumn.Text = "Příjmení";
            this.surrColumn.Width = 148;
            // 
            // idColumn
            // 
            this.idColumn.DisplayIndex = 0;
            this.idColumn.Text = "id";
            this.idColumn.Width = 24;
            // 
            // loanColumn
            // 
            this.loanColumn.Text = "Výpůjčeno";
            this.loanColumn.Width = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vypůjčené knihy";
            // 
            // LVoddeleni
            // 
            this.LVoddeleni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.columnHeader1});
            this.LVoddeleni.HideSelection = false;
            this.LVoddeleni.Location = new System.Drawing.Point(6, 28);
            this.LVoddeleni.Name = "LVoddeleni";
            this.LVoddeleni.Size = new System.Drawing.Size(252, 464);
            this.LVoddeleni.TabIndex = 8;
            this.LVoddeleni.UseCompatibleStateImageBehavior = false;
            this.LVoddeleni.View = System.Windows.Forms.View.Details;
            this.LVoddeleni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oddActive);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Název";
            this.nameColumn.Width = 170;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Počet knih";
            this.columnHeader1.Width = 75;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1038, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1039, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Vložit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddOnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1039, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Upravit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EditOnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1039, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Odebrat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteOnClick);
            // 
            // LVvypujc
            // 
            this.LVvypujc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.LVvypujc.HideSelection = false;
            this.LVvypujc.Location = new System.Drawing.Point(780, 28);
            this.LVvypujc.Name = "LVvypujc";
            this.LVvypujc.Size = new System.Drawing.Size(252, 464);
            this.LVvypujc.TabIndex = 13;
            this.LVvypujc.UseCompatibleStateImageBehavior = false;
            this.LVvypujc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Název";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Autor";
            this.columnHeader6.Width = 86;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ISBN";
            this.columnHeader7.Width = 57;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1039, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Vypůjči";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.vypujci_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1039, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Vrať";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.vrat_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1039, 469);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Načti";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.nacti_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1039, 440);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Ulož";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.uloz_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 507);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.LVvypujc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LVoddeleni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LVzakaznici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVknihy);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVknihy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView LVzakaznici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView LVoddeleni;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader surrColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader loanColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView LVvypujc;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

