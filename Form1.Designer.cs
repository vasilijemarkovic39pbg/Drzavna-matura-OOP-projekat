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
            this.prikazi_ucenike = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.snimi_podatke = new System.Windows.Forms.Button();
            this.lista_ucenika = new System.Windows.Forms.ListBox();
            this.dodaj_ucenika = new System.Windows.Forms.Button();
            this.treci_predmet_box = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.drugi_predmet_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prvi_predmet_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jezik_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tip_mature_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.odeljenje_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ime_prezime_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profil_box = new System.Windows.Forms.ComboBox();
            this.profil_tab = new System.Windows.Forms.TabPage();
            this.prikazi_profile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sacuvaj_profil = new System.Windows.Forms.Button();
            this.lista_profila = new System.Windows.Forms.ListBox();
            this.dodaj_profil = new System.Windows.Forms.Button();
            this.treci_predmet_profil_box = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.drugi_predmet_profil_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.prvi_predmet_profil_box = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.jezik_profil_box = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tip_mature_profil_box = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.odeljenje_profil_box = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.naziv_profila_box = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(936, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // ucenik_tab
            // 
            this.ucenik_tab.Controls.Add(this.prikazi_ucenike);
            this.ucenik_tab.Controls.Add(this.label16);
            this.ucenik_tab.Controls.Add(this.snimi_podatke);
            this.ucenik_tab.Controls.Add(this.lista_ucenika);
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
            this.ucenik_tab.Size = new System.Drawing.Size(928, 351);
            this.ucenik_tab.TabIndex = 0;
            this.ucenik_tab.Text = "Ucenik";
            this.ucenik_tab.UseVisualStyleBackColor = true;
            // 
            // prikazi_ucenike
            // 
            this.prikazi_ucenike.Location = new System.Drawing.Point(6, 310);
            this.prikazi_ucenike.Name = "prikazi_ucenike";
            this.prikazi_ucenike.Size = new System.Drawing.Size(162, 35);
            this.prikazi_ucenike.TabIndex = 21;
            this.prikazi_ucenike.Text = "Prikazi sacuvane podatke";
            this.prikazi_ucenike.UseVisualStyleBackColor = true;
            this.prikazi_ucenike.Click += new System.EventHandler(this.prikazi_ucenike_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(357, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Lista unetih ucenika:";
            // 
            // snimi_podatke
            // 
            this.snimi_podatke.Location = new System.Drawing.Point(6, 269);
            this.snimi_podatke.Name = "snimi_podatke";
            this.snimi_podatke.Size = new System.Drawing.Size(162, 35);
            this.snimi_podatke.TabIndex = 19;
            this.snimi_podatke.Text = "Sacuvaj podatke";
            this.snimi_podatke.UseVisualStyleBackColor = true;
            this.snimi_podatke.Click += new System.EventHandler(this.snimi_podatke_Click);
            // 
            // lista_ucenika
            // 
            this.lista_ucenika.FormattingEnabled = true;
            this.lista_ucenika.Location = new System.Drawing.Point(360, 29);
            this.lista_ucenika.Name = "lista_ucenika";
            this.lista_ucenika.Size = new System.Drawing.Size(562, 316);
            this.lista_ucenika.TabIndex = 18;
            // 
            // dodaj_ucenika
            // 
            this.dodaj_ucenika.Location = new System.Drawing.Point(6, 228);
            this.dodaj_ucenika.Name = "dodaj_ucenika";
            this.dodaj_ucenika.Size = new System.Drawing.Size(162, 35);
            this.dodaj_ucenika.TabIndex = 17;
            this.dodaj_ucenika.Text = "Dodaj ucenika";
            this.dodaj_ucenika.UseVisualStyleBackColor = true;
            this.dodaj_ucenika.Click += new System.EventHandler(this.dodaj_ucenika_Click);
            // 
            // treci_predmet_box
            // 
            this.treci_predmet_box.FormattingEnabled = true;
            this.treci_predmet_box.Location = new System.Drawing.Point(6, 201);
            this.treci_predmet_box.Name = "treci_predmet_box";
            this.treci_predmet_box.Size = new System.Drawing.Size(348, 21);
            this.treci_predmet_box.TabIndex = 16;
            this.treci_predmet_box.SelectedIndexChanged += new System.EventHandler(this.profil_box_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Treci predmet";
            // 
            // drugi_predmet_box
            // 
            this.drugi_predmet_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drugi_predmet_box.Location = new System.Drawing.Point(192, 161);
            this.drugi_predmet_box.Name = "drugi_predmet_box";
            this.drugi_predmet_box.ReadOnly = true;
            this.drugi_predmet_box.Size = new System.Drawing.Size(162, 20);
            this.drugi_predmet_box.TabIndex = 14;
            this.drugi_predmet_box.Text = "Matematika";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Drugi predmet";
            // 
            // prvi_predmet_box
            // 
            this.prvi_predmet_box.FormattingEnabled = true;
            this.prvi_predmet_box.Location = new System.Drawing.Point(6, 160);
            this.prvi_predmet_box.Name = "prvi_predmet_box";
            this.prvi_predmet_box.Size = new System.Drawing.Size(162, 21);
            this.prvi_predmet_box.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prvi predmet";
            // 
            // jezik_box
            // 
            this.jezik_box.FormattingEnabled = true;
            this.jezik_box.Location = new System.Drawing.Point(192, 120);
            this.jezik_box.Name = "jezik_box";
            this.jezik_box.Size = new System.Drawing.Size(162, 21);
            this.jezik_box.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jezik";
            // 
            // tip_mature_box
            // 
            this.tip_mature_box.FormattingEnabled = true;
            this.tip_mature_box.Location = new System.Drawing.Point(6, 120);
            this.tip_mature_box.Name = "tip_mature_box";
            this.tip_mature_box.Size = new System.Drawing.Size(162, 21);
            this.tip_mature_box.TabIndex = 8;
            this.tip_mature_box.SelectedIndexChanged += new System.EventHandler(this.tip_mature_box_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tip mature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odeljenje";
            // 
            // odeljenje_box
            // 
            this.odeljenje_box.Location = new System.Drawing.Point(192, 81);
            this.odeljenje_box.Name = "odeljenje_box";
            this.odeljenje_box.Size = new System.Drawing.Size(162, 20);
            this.odeljenje_box.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime i prezime";
            // 
            // ime_prezime_box
            // 
            this.ime_prezime_box.Location = new System.Drawing.Point(6, 81);
            this.ime_prezime_box.Name = "ime_prezime_box";
            this.ime_prezime_box.Size = new System.Drawing.Size(162, 20);
            this.ime_prezime_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profil";
            // 
            // profil_box
            // 
            this.profil_box.FormattingEnabled = true;
            this.profil_box.Location = new System.Drawing.Point(6, 29);
            this.profil_box.Name = "profil_box";
            this.profil_box.Size = new System.Drawing.Size(348, 21);
            this.profil_box.TabIndex = 0;
            // 
            // profil_tab
            // 
            this.profil_tab.Controls.Add(this.prikazi_profile);
            this.profil_tab.Controls.Add(this.label9);
            this.profil_tab.Controls.Add(this.sacuvaj_profil);
            this.profil_tab.Controls.Add(this.lista_profila);
            this.profil_tab.Controls.Add(this.dodaj_profil);
            this.profil_tab.Controls.Add(this.treci_predmet_profil_box);
            this.profil_tab.Controls.Add(this.label10);
            this.profil_tab.Controls.Add(this.drugi_predmet_profil_box);
            this.profil_tab.Controls.Add(this.label11);
            this.profil_tab.Controls.Add(this.prvi_predmet_profil_box);
            this.profil_tab.Controls.Add(this.label12);
            this.profil_tab.Controls.Add(this.jezik_profil_box);
            this.profil_tab.Controls.Add(this.label13);
            this.profil_tab.Controls.Add(this.tip_mature_profil_box);
            this.profil_tab.Controls.Add(this.label14);
            this.profil_tab.Controls.Add(this.label15);
            this.profil_tab.Controls.Add(this.odeljenje_profil_box);
            this.profil_tab.Controls.Add(this.label17);
            this.profil_tab.Controls.Add(this.naziv_profila_box);
            this.profil_tab.Location = new System.Drawing.Point(4, 22);
            this.profil_tab.Name = "profil_tab";
            this.profil_tab.Padding = new System.Windows.Forms.Padding(3);
            this.profil_tab.Size = new System.Drawing.Size(928, 351);
            this.profil_tab.TabIndex = 1;
            this.profil_tab.Text = "Profil";
            this.profil_tab.UseVisualStyleBackColor = true;
            // 
            // prikazi_profile
            // 
            this.prikazi_profile.Location = new System.Drawing.Point(6, 311);
            this.prikazi_profile.Name = "prikazi_profile";
            this.prikazi_profile.Size = new System.Drawing.Size(162, 35);
            this.prikazi_profile.TabIndex = 42;
            this.prikazi_profile.Text = "Prikazi sacuvane profile";
            this.prikazi_profile.UseVisualStyleBackColor = true;
            this.prikazi_profile.Click += new System.EventHandler(this.prikazi_profile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Lista unetih profila:";
            // 
            // sacuvaj_profil
            // 
            this.sacuvaj_profil.Location = new System.Drawing.Point(6, 270);
            this.sacuvaj_profil.Name = "sacuvaj_profil";
            this.sacuvaj_profil.Size = new System.Drawing.Size(162, 35);
            this.sacuvaj_profil.TabIndex = 40;
            this.sacuvaj_profil.Text = "Sacuvaj profil";
            this.sacuvaj_profil.UseVisualStyleBackColor = true;
            this.sacuvaj_profil.Click += new System.EventHandler(this.sacuvaj_profil_Click);
            // 
            // lista_profila
            // 
            this.lista_profila.FormattingEnabled = true;
            this.lista_profila.Location = new System.Drawing.Point(360, 30);
            this.lista_profila.Name = "lista_profila";
            this.lista_profila.Size = new System.Drawing.Size(562, 316);
            this.lista_profila.TabIndex = 39;
            // 
            // dodaj_profil
            // 
            this.dodaj_profil.Location = new System.Drawing.Point(6, 229);
            this.dodaj_profil.Name = "dodaj_profil";
            this.dodaj_profil.Size = new System.Drawing.Size(162, 35);
            this.dodaj_profil.TabIndex = 38;
            this.dodaj_profil.Text = "Dodaj profil";
            this.dodaj_profil.UseVisualStyleBackColor = true;
            this.dodaj_profil.Click += new System.EventHandler(this.dodaj_profil_Click);
            // 
            // treci_predmet_profil_box
            // 
            this.treci_predmet_profil_box.FormattingEnabled = true;
            this.treci_predmet_profil_box.Location = new System.Drawing.Point(6, 150);
            this.treci_predmet_profil_box.Name = "treci_predmet_profil_box";
            this.treci_predmet_profil_box.Size = new System.Drawing.Size(348, 21);
            this.treci_predmet_profil_box.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Treci predmet";
            // 
            // drugi_predmet_profil_box
            // 
            this.drugi_predmet_profil_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drugi_predmet_profil_box.Location = new System.Drawing.Point(192, 110);
            this.drugi_predmet_profil_box.Name = "drugi_predmet_profil_box";
            this.drugi_predmet_profil_box.ReadOnly = true;
            this.drugi_predmet_profil_box.Size = new System.Drawing.Size(162, 20);
            this.drugi_predmet_profil_box.TabIndex = 35;
            this.drugi_predmet_profil_box.Text = "Matematika";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Drugi predmet";
            // 
            // prvi_predmet_profil_box
            // 
            this.prvi_predmet_profil_box.FormattingEnabled = true;
            this.prvi_predmet_profil_box.Location = new System.Drawing.Point(6, 109);
            this.prvi_predmet_profil_box.Name = "prvi_predmet_profil_box";
            this.prvi_predmet_profil_box.Size = new System.Drawing.Size(162, 21);
            this.prvi_predmet_profil_box.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Prvi predmet";
            // 
            // jezik_profil_box
            // 
            this.jezik_profil_box.FormattingEnabled = true;
            this.jezik_profil_box.Location = new System.Drawing.Point(192, 69);
            this.jezik_profil_box.Name = "jezik_profil_box";
            this.jezik_profil_box.Size = new System.Drawing.Size(162, 21);
            this.jezik_profil_box.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Jezik";
            // 
            // tip_mature_profil_box
            // 
            this.tip_mature_profil_box.FormattingEnabled = true;
            this.tip_mature_profil_box.Location = new System.Drawing.Point(6, 69);
            this.tip_mature_profil_box.Name = "tip_mature_profil_box";
            this.tip_mature_profil_box.Size = new System.Drawing.Size(162, 21);
            this.tip_mature_profil_box.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tip mature";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(189, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Odeljenje";
            // 
            // odeljenje_profil_box
            // 
            this.odeljenje_profil_box.Location = new System.Drawing.Point(192, 30);
            this.odeljenje_profil_box.Name = "odeljenje_profil_box";
            this.odeljenje_profil_box.Size = new System.Drawing.Size(162, 20);
            this.odeljenje_profil_box.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Naziv profila";
            // 
            // naziv_profila_box
            // 
            this.naziv_profila_box.Location = new System.Drawing.Point(6, 30);
            this.naziv_profila_box.Name = "naziv_profila_box";
            this.naziv_profila_box.Size = new System.Drawing.Size(162, 20);
            this.naziv_profila_box.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 402);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox prvi_predmet_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox treci_predmet_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dodaj_ucenika;
        public System.Windows.Forms.TextBox drugi_predmet_box;
        private System.Windows.Forms.ListBox lista_ucenika;
        private System.Windows.Forms.Button snimi_podatke;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button prikazi_ucenike;
        private System.Windows.Forms.Button prikazi_profile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sacuvaj_profil;
        private System.Windows.Forms.ListBox lista_profila;
        private System.Windows.Forms.Button dodaj_profil;
        private System.Windows.Forms.ComboBox treci_predmet_profil_box;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox drugi_predmet_profil_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox prvi_predmet_profil_box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox jezik_profil_box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox tip_mature_profil_box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox odeljenje_profil_box;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox naziv_profila_box;
    }
}

