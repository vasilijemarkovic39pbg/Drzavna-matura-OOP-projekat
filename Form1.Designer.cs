namespace Drzavna_matura
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ucenik_tab = new System.Windows.Forms.TabPage();
            this.profil_tab = new System.Windows.Forms.TabPage();
            this.profil_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ime_prezime_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.odeljenje_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tip_mature_box = new System.Windows.Forms.ComboBox();
            this.jezik_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prvi_predmet_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.drugi_predmet_box = new System.Windows.Forms.TextBox();
            this.treci_predmet_box = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dodaj_ucenika = new System.Windows.Forms.Button();
            this.sacuvaj_profil = new System.Windows.Forms.Button();
            this.treci_predmet_profil_box = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.drugi_predmet_profil_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.prvi_predmet_profil_box = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.jezik_profil_box = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tip_mature_profil_box = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.odeljenje_profil_box = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.naziv_box = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.ucenik_tab.SuspendLayout();
            this.profil_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ucenik_tab);
            this.tabControl1.Controls.Add(this.profil_tab);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // ucenik_tab
            // 
            this.ucenik_tab.Controls.Add(this.dodaj_ucenika);
            this.ucenik_tab.Controls.Add(this.treci_predmet_box);
            this.ucenik_tab.Controls.Add(this.label8);
            this.ucenik_tab.Controls.Add(this.drugi_predmet_box);
            this.ucenik_tab.Controls.Add(this.label7);
            this.ucenik_tab.Controls.Add(this.prvi_predmet_box);
            this.ucenik_tab.Controls.Add(this.label6);
            this.ucenik_tab.Controls.Add(this.jezik_box);
            this.ucenik_tab.Controls.Add(this.label5);
            this.ucenik_tab.Controls.Add(this.tip_mature_box);
            this.ucenik_tab.Controls.Add(this.label4);
            this.ucenik_tab.Controls.Add(this.label3);
            this.ucenik_tab.Controls.Add(this.odeljenje_box);
            this.ucenik_tab.Controls.Add(this.label2);
            this.ucenik_tab.Controls.Add(this.ime_prezime_box);
            this.ucenik_tab.Controls.Add(this.label1);
            this.ucenik_tab.Controls.Add(this.profil_box);
            this.ucenik_tab.Location = new System.Drawing.Point(4, 22);
            this.ucenik_tab.Name = "ucenik_tab";
            this.ucenik_tab.Padding = new System.Windows.Forms.Padding(3);
            this.ucenik_tab.Size = new System.Drawing.Size(767, 399);
            this.ucenik_tab.TabIndex = 0;
            this.ucenik_tab.Text = "Ucenik";
            this.ucenik_tab.UseVisualStyleBackColor = true;
            // 
            // profil_tab
            // 
            this.profil_tab.Controls.Add(this.sacuvaj_profil);
            this.profil_tab.Controls.Add(this.treci_predmet_profil_box);
            this.profil_tab.Controls.Add(this.label9);
            this.profil_tab.Controls.Add(this.drugi_predmet_profil_box);
            this.profil_tab.Controls.Add(this.label10);
            this.profil_tab.Controls.Add(this.prvi_predmet_profil_box);
            this.profil_tab.Controls.Add(this.label11);
            this.profil_tab.Controls.Add(this.jezik_profil_box);
            this.profil_tab.Controls.Add(this.label12);
            this.profil_tab.Controls.Add(this.tip_mature_profil_box);
            this.profil_tab.Controls.Add(this.label13);
            this.profil_tab.Controls.Add(this.label14);
            this.profil_tab.Controls.Add(this.odeljenje_profil_box);
            this.profil_tab.Controls.Add(this.label15);
            this.profil_tab.Controls.Add(this.naziv_box);
            this.profil_tab.Location = new System.Drawing.Point(4, 22);
            this.profil_tab.Name = "profil_tab";
            this.profil_tab.Padding = new System.Windows.Forms.Padding(3);
            this.profil_tab.Size = new System.Drawing.Size(767, 399);
            this.profil_tab.TabIndex = 1;
            this.profil_tab.Text = "Profil";
            this.profil_tab.UseVisualStyleBackColor = true;
            // 
            // profil_box
            // 
            this.profil_box.FormattingEnabled = true;
            this.profil_box.Location = new System.Drawing.Point(6, 19);
            this.profil_box.Name = "profil_box";
            this.profil_box.Size = new System.Drawing.Size(162, 21);
            this.profil_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profil";
            // 
            // ime_prezime_box
            // 
            this.ime_prezime_box.Location = new System.Drawing.Point(6, 71);
            this.ime_prezime_box.Name = "ime_prezime_box";
            this.ime_prezime_box.Size = new System.Drawing.Size(162, 20);
            this.ime_prezime_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime i prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odeljenje";
            // 
            // odeljenje_box
            // 
            this.odeljenje_box.Location = new System.Drawing.Point(201, 71);
            this.odeljenje_box.Name = "odeljenje_box";
            this.odeljenje_box.Size = new System.Drawing.Size(162, 20);
            this.odeljenje_box.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tip mature";
            // 
            // tip_mature_box
            // 
            this.tip_mature_box.FormattingEnabled = true;
            this.tip_mature_box.Location = new System.Drawing.Point(397, 71);
            this.tip_mature_box.Name = "tip_mature_box";
            this.tip_mature_box.Size = new System.Drawing.Size(162, 21);
            this.tip_mature_box.TabIndex = 8;
            // 
            // jezik_box
            // 
            this.jezik_box.FormattingEnabled = true;
            this.jezik_box.Location = new System.Drawing.Point(593, 71);
            this.jezik_box.Name = "jezik_box";
            this.jezik_box.Size = new System.Drawing.Size(162, 21);
            this.jezik_box.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jezik";
            // 
            // prvi_predmet_box
            // 
            this.prvi_predmet_box.FormattingEnabled = true;
            this.prvi_predmet_box.Location = new System.Drawing.Point(6, 122);
            this.prvi_predmet_box.Name = "prvi_predmet_box";
            this.prvi_predmet_box.Size = new System.Drawing.Size(162, 21);
            this.prvi_predmet_box.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prvi predmet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Drugi predmet";
            // 
            // drugi_predmet_box
            // 
            this.drugi_predmet_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drugi_predmet_box.Location = new System.Drawing.Point(201, 123);
            this.drugi_predmet_box.Name = "drugi_predmet_box";
            this.drugi_predmet_box.ReadOnly = true;
            this.drugi_predmet_box.Size = new System.Drawing.Size(162, 20);
            this.drugi_predmet_box.TabIndex = 14;
            this.drugi_predmet_box.Text = "Matematika";
            // 
            // treci_predmet_box
            // 
            this.treci_predmet_box.FormattingEnabled = true;
            this.treci_predmet_box.Location = new System.Drawing.Point(397, 123);
            this.treci_predmet_box.Name = "treci_predmet_box";
            this.treci_predmet_box.Size = new System.Drawing.Size(162, 21);
            this.treci_predmet_box.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Treci predmet";
            // 
            // dodaj_ucenika
            // 
            this.dodaj_ucenika.Location = new System.Drawing.Point(593, 122);
            this.dodaj_ucenika.Name = "dodaj_ucenika";
            this.dodaj_ucenika.Size = new System.Drawing.Size(162, 24);
            this.dodaj_ucenika.TabIndex = 17;
            this.dodaj_ucenika.Text = "Dodaj ucenika";
            this.dodaj_ucenika.UseVisualStyleBackColor = true;
            // 
            // sacuvaj_profil
            // 
            this.sacuvaj_profil.Location = new System.Drawing.Point(593, 70);
            this.sacuvaj_profil.Name = "sacuvaj_profil";
            this.sacuvaj_profil.Size = new System.Drawing.Size(162, 24);
            this.sacuvaj_profil.TabIndex = 34;
            this.sacuvaj_profil.Text = "Sacuvaj profil";
            this.sacuvaj_profil.UseVisualStyleBackColor = true;
            // 
            // treci_predmet_profil_box
            // 
            this.treci_predmet_profil_box.FormattingEnabled = true;
            this.treci_predmet_profil_box.Location = new System.Drawing.Point(397, 71);
            this.treci_predmet_profil_box.Name = "treci_predmet_profil_box";
            this.treci_predmet_profil_box.Size = new System.Drawing.Size(162, 21);
            this.treci_predmet_profil_box.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Treci predmet";
            // 
            // drugi_predmet_profil_box
            // 
            this.drugi_predmet_profil_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drugi_predmet_profil_box.Location = new System.Drawing.Point(201, 71);
            this.drugi_predmet_profil_box.Name = "drugi_predmet_profil_box";
            this.drugi_predmet_profil_box.ReadOnly = true;
            this.drugi_predmet_profil_box.Size = new System.Drawing.Size(162, 20);
            this.drugi_predmet_profil_box.TabIndex = 31;
            this.drugi_predmet_profil_box.Text = "Matematika";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Drugi predmet";
            // 
            // prvi_predmet_profil_box
            // 
            this.prvi_predmet_profil_box.FormattingEnabled = true;
            this.prvi_predmet_profil_box.Location = new System.Drawing.Point(6, 70);
            this.prvi_predmet_profil_box.Name = "prvi_predmet_profil_box";
            this.prvi_predmet_profil_box.Size = new System.Drawing.Size(162, 21);
            this.prvi_predmet_profil_box.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Prvi predmet";
            // 
            // jezik_profil_box
            // 
            this.jezik_profil_box.FormattingEnabled = true;
            this.jezik_profil_box.Location = new System.Drawing.Point(593, 19);
            this.jezik_profil_box.Name = "jezik_profil_box";
            this.jezik_profil_box.Size = new System.Drawing.Size(162, 21);
            this.jezik_profil_box.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(590, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Jezik";
            // 
            // tip_mature_profil_box
            // 
            this.tip_mature_profil_box.FormattingEnabled = true;
            this.tip_mature_profil_box.Location = new System.Drawing.Point(397, 19);
            this.tip_mature_profil_box.Name = "tip_mature_profil_box";
            this.tip_mature_profil_box.Size = new System.Drawing.Size(162, 21);
            this.tip_mature_profil_box.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tip mature";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Odeljenje";
            // 
            // odeljenje_profil_box
            // 
            this.odeljenje_profil_box.Location = new System.Drawing.Point(201, 19);
            this.odeljenje_profil_box.Name = "odeljenje_profil_box";
            this.odeljenje_profil_box.Size = new System.Drawing.Size(162, 20);
            this.odeljenje_profil_box.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Naziv profila";
            // 
            // naziv_box
            // 
            this.naziv_box.Location = new System.Drawing.Point(6, 19);
            this.naziv_box.Name = "naziv_box";
            this.naziv_box.Size = new System.Drawing.Size(162, 20);
            this.naziv_box.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ucenik_tab.ResumeLayout(false);
            this.ucenik_tab.PerformLayout();
            this.profil_tab.ResumeLayout(false);
            this.profil_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ucenik_tab;
        private System.Windows.Forms.TabPage profil_tab;
        private System.Windows.Forms.ComboBox profil_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ime_prezime_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox odeljenje_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tip_mature_box;
        private System.Windows.Forms.ComboBox jezik_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox drugi_predmet_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox prvi_predmet_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox treci_predmet_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dodaj_ucenika;
        private System.Windows.Forms.Button sacuvaj_profil;
        private System.Windows.Forms.ComboBox treci_predmet_profil_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox drugi_predmet_profil_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox prvi_predmet_profil_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox jezik_profil_box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox tip_mature_profil_box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox odeljenje_profil_box;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox naziv_box;
    }
}

