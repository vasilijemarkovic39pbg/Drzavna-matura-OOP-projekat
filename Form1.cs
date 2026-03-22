using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drzavna_matura
{
    public partial class Form1 : Form
    {
        private string[] jeziciGrupa1 = {
            "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost",
            "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost",
            "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost"
        };

        private string[] opstaMaturaPredmeti3 = {
            "Biologija", "Geografija", "Engleski jezik", "Istorija", "Italijanski jezik",
            "Nemački jezik", "Ruski jezik", "Srpski kao nematernji jezik", "Fizika",
            "Francuski jezik", "Hemija", "Španski jezik"
        };

        private string[] strucnaMaturaPredmeti3 = {
            "Zootehničar", "Tehničar za biotehnologiju", "Šumarski tehničar",
            "Medicinska sestra – vaspitač", "Ekonomski tehničar"
        };

        private string[] umetnickaMaturaPredmeti3 = {
            "Solfeđo i harmonija", "Ništa (Ostali umetnički profili)"
        };

        private List<Ucenik> svi_ucenici = new List<Ucenik>();
        private List<ProfilSema> sviProfili = new List<ProfilSema>();

        public Form1()
        {
            InitializeComponent();
            InicijalizujPodatke();
            UcitajProfile();
        }

        public void InicijalizujPodatke()
        {
            profil_box.SelectedIndexChanged += profil_box_SelectedIndexChanged;
            tip_mature_profil_box.SelectedIndexChanged += tip_mature_profil_box_SelectedIndexChanged;
            tip_mature_box.DataSource = Enum.GetValues(typeof(TipMature));
            prvi_predmet_box.DataSource = jeziciGrupa1;
            drugi_predmet_box.Text = "Matematika";
            drugi_predmet_box.ReadOnly = true;
            jezik_box.DataSource = jeziciGrupa1;

            tip_mature_profil_box.DataSource = Enum.GetValues(typeof(TipMature));
            prvi_predmet_profil_box.DataSource = jeziciGrupa1;
            drugi_predmet_profil_box.Text = "Matematika";
            drugi_predmet_profil_box.ReadOnly = true;
            jezik_profil_box.DataSource = jeziciGrupa1;
            tip_mature_profil_box_SelectedIndexChanged(null, null);
        }

        private void tip_mature_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tip_mature_box.SelectedItem == null)
                return;

            TipMature izabraniTip = (TipMature)tip_mature_box.SelectedItem;
            
            treci_predmet_box.Items.Clear();
            treci_predmet_box.Text = "";

            switch (izabraniTip)
            {
                case TipMature.Opsta:
                    treci_predmet_box.Items.AddRange(opstaMaturaPredmeti3);
                    break;

                case TipMature.Strucna:
                    treci_predmet_box.Items.AddRange(strucnaMaturaPredmeti3);
                    break;

                case TipMature.Umetnicka:
                    treci_predmet_box.Items.AddRange(umetnickaMaturaPredmeti3);
                    break;
            }
        }

        private void tip_mature_profil_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tip_mature_profil_box.SelectedItem == null)
                return;

            TipMature izabraniTip = (TipMature)tip_mature_profil_box.SelectedItem;

            treci_predmet_profil_box.Items.Clear();
            treci_predmet_profil_box.Text = "";

            switch (izabraniTip)
            {
                case TipMature.Opsta:
                    treci_predmet_profil_box.Items.AddRange(opstaMaturaPredmeti3);
                    break;

                case TipMature.Strucna:
                    treci_predmet_profil_box.Items.AddRange(strucnaMaturaPredmeti3);
                    break;

                case TipMature.Umetnicka:
                    treci_predmet_profil_box.Items.AddRange(umetnickaMaturaPredmeti3);
                    break;
            }
        }

        private void dodaj_ucenika_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ime_prezime_box.Text) ||
            string.IsNullOrWhiteSpace(odeljenje_box.Text) ||
            prvi_predmet_box.SelectedItem == null ||
            treci_predmet_box.SelectedItem == null ||
            jezik_box.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da popunite sve podatke o učeniku!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string prviPredmet = prvi_predmet_box.SelectedItem.ToString();
            string treciPredmet = treci_predmet_box.SelectedItem.ToString();

            if (prviPredmet == treciPredmet)
            {
                MessageBox.Show("Greška! Učenik ne može polagati isti predmet kao 1. i 3. izborni predmet.", "Zabranjeno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] imeIprezime = ime_prezime_box.Text.Split(' ');
            string ime = "";
            string prezime = "";

            if (imeIprezime.Length >= 2)
            {
                ime = imeIprezime[0];
                prezime = imeIprezime[1];
            }
            else
            {
                MessageBox.Show("Molimo vas unesite i ime i prezime (odvojeno razmakom).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ucenik noviUcenik = new Ucenik();
            noviUcenik.ime = ime;
            noviUcenik.prezime = prezime;
            noviUcenik.odeljenje = odeljenje_box.Text;
            noviUcenik.tipMature = (TipMature)tip_mature_box.SelectedItem;
            noviUcenik.JezikPolaganja = jezik_box.SelectedItem.ToString();
            noviUcenik.PrviPredmet = prviPredmet;
            noviUcenik.DrugiPredmet = drugi_predmet_box.Text;
            noviUcenik.TreciPredmet = treciPredmet;

            svi_ucenici.Add(noviUcenik);

            lista_ucenika.Items.Add($"{noviUcenik.ime} {noviUcenik.prezime}, {noviUcenik.odeljenje}, {noviUcenik.tipMature}, {noviUcenik.JezikPolaganja}, {noviUcenik.PrviPredmet}, {noviUcenik.DrugiPredmet}, {noviUcenik.TreciPredmet}");
            ime_prezime_box.Clear();
            ime_prezime_box.Focus();
        }

        private void snimi_podatke_Click(object sender, EventArgs e)
        {
            if (svi_ucenici.Count == 0)
            {
                MessageBox.Show("Nema učenika za cuvanje!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter("ucenici.txt"))
                {
                    foreach (Ucenik u in svi_ucenici)
                    {
                        string upis = $"{u.ime},{u.prezime},{u.odeljenje},{u.tipMature},{u.JezikPolaganja},{u.PrviPredmet},{u.DrugiPredmet},{u.TreciPredmet}";
                        sw.WriteLine(upis);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prikazi_ucenike_Click(object sender, EventArgs e)
        {
            if (!File.Exists("ucenici.txt"))
            {
                MessageBox.Show("Fajl sa učenicima nije kreiran.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                svi_ucenici.Clear();
                lista_ucenika.Items.Clear();

                using (StreamReader sr = new StreamReader("ucenici.txt"))
                {
                    string linija_txt;

                    while ((linija_txt = sr.ReadLine()) != null)
                    {
                        string[] delovi = linija_txt.Split(',');

                        if (delovi.Length == 8)
                        {
                            Ucenik ucitan_u = new Ucenik();

                            ucitan_u.ime = delovi[0];
                            ucitan_u.prezime = delovi[1];
                            ucitan_u.odeljenje = delovi[2];
                            Enum.TryParse(delovi[3], out TipMature tip);
                            ucitan_u.tipMature = tip;
                            ucitan_u.JezikPolaganja = delovi[4];
                            ucitan_u.PrviPredmet = delovi[5];
                            ucitan_u.DrugiPredmet = delovi[6];
                            ucitan_u.TreciPredmet = delovi[7];

                            svi_ucenici.Add(ucitan_u);
                            lista_ucenika.Items.Add($"{ucitan_u.ime} {ucitan_u.prezime}, {ucitan_u.odeljenje}, {ucitan_u.tipMature}, {ucitan_u.JezikPolaganja}, {ucitan_u.PrviPredmet}, {ucitan_u.DrugiPredmet}, {ucitan_u.TreciPredmet}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // profil

        private void sacuvaj_profil_Click(object sender, EventArgs e)
        {
            if (sviProfili.Count == 0)
            {
                MessageBox.Show("Nema profila za cuvanje!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter("profili.txt"))
                {
                    foreach (ProfilSema p in sviProfili)
                    {
                        string upis = $"{p.NazivProfila},{p.odeljenje},{p.tipMature},{p.JezikPolaganja},{p.PrviPredmet},{p.DrugiPredmet},{p.TreciPredmet}";
                        sw.WriteLine(upis);
                    }
                }

                MessageBox.Show("Profili su uspešno sačuvani!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                naziv_profila_box.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dodaj_profil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(naziv_profila_box.Text))
            {
                MessageBox.Show("Morate uneti naziv profila!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProfilSema noviProfil = new ProfilSema();
            noviProfil.NazivProfila = naziv_profila_box.Text;
            noviProfil.odeljenje = odeljenje_profil_box.Text;
            noviProfil.tipMature = (TipMature)tip_mature_profil_box.SelectedItem;
            noviProfil.JezikPolaganja = jezik_profil_box.SelectedItem.ToString();
            noviProfil.PrviPredmet = prvi_predmet_profil_box.SelectedItem.ToString();
            noviProfil.TreciPredmet = treci_predmet_profil_box.SelectedItem.ToString();

            sviProfili.Add(noviProfil);
            lista_profila.Items.Add($"{noviProfil.NazivProfila},{noviProfil.odeljenje},{noviProfil.tipMature},{noviProfil.JezikPolaganja},{noviProfil.PrviPredmet},{noviProfil.DrugiPredmet},{noviProfil.TreciPredmet}");
            profil_box.Items.Add(noviProfil);
        }

        private void prikazi_profile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("profili.txt"))
            {
                MessageBox.Show("Fajl sa profilima nije kreiran.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                lista_profila.Items.Clear();

                using (StreamReader sr = new StreamReader("profili.txt"))
                {
                    string linija_txt;

                    while ((linija_txt = sr.ReadLine()) != null)
                    {
                        string[] delovi = linija_txt.Split(',');

                        if (delovi.Length == 7)
                        {
                            ProfilSema ucitan_p = new ProfilSema();

                            ucitan_p.NazivProfila = delovi[0];
                            ucitan_p.odeljenje = delovi[1];
                            Enum.TryParse(delovi[2], out TipMature tip);
                            ucitan_p.tipMature = tip;
                            ucitan_p.JezikPolaganja = delovi[3];
                            ucitan_p.PrviPredmet = delovi[4];
                            ucitan_p.DrugiPredmet = delovi[5];
                            ucitan_p.TreciPredmet = delovi[6];

                            sviProfili.Add(ucitan_p);
                            lista_profila.Items.Add($"{ucitan_p.NazivProfila}, {ucitan_p.odeljenje}, {ucitan_p.tipMature}, {ucitan_p.JezikPolaganja}, {ucitan_p.PrviPredmet}, {ucitan_p.DrugiPredmet}, {ucitan_p.TreciPredmet}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UcitajProfile()
        {
            profil_box.Items.Clear();
            sviProfili.Clear();

            if (File.Exists("profili.txt"))
            {
                try
                {
                    using (StreamReader sr = new StreamReader("profili.txt"))
                    {
                        string linija;
                        while ((linija = sr.ReadLine()) != null)
                        {
                            string[] delovi = linija.Split(',');

                            if (delovi.Length == 7)
                            {
                                ProfilSema ucitaniProfil = new ProfilSema();
                                ucitaniProfil.NazivProfila = delovi[0];
                                ucitaniProfil.odeljenje = delovi[1];

                                Enum.TryParse(delovi[2], out TipMature tip);
                                ucitaniProfil.tipMature = tip;

                                ucitaniProfil.JezikPolaganja = delovi[3];
                                ucitaniProfil.PrviPredmet = delovi[4];
                                ucitaniProfil.TreciPredmet = delovi[6];

                                sviProfili.Add(ucitaniProfil);
                                profil_box.Items.Add(ucitaniProfil);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri učitavanju profila: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void profil_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (profil_box.SelectedItem == null)
                return;

            ProfilSema izabraniProfil = (ProfilSema)profil_box.SelectedItem;

            odeljenje_box.Text = izabraniProfil.odeljenje;
            tip_mature_box.SelectedItem = izabraniProfil.tipMature;
            jezik_box.SelectedItem = izabraniProfil.JezikPolaganja;
            prvi_predmet_box.SelectedItem = izabraniProfil.PrviPredmet;
            treci_predmet_box.SelectedItem = izabraniProfil.TreciPredmet;
        }
    }
}
