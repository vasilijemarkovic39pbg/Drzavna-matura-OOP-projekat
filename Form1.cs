using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
            InitializeComponent();
            InicijalizujPodatke();
        }

        public void InicijalizujPodatke()
        {
            tip_mature_box.DataSource = Enum.GetValues(typeof(TipMature));
            prvi_predmet_box.DataSource = jeziciGrupa1;
            drugi_predmet_box.Text = "Математика";
            drugi_predmet_box.ReadOnly = true;
            jezik_box.DataSource = jeziciGrupa1;
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

            lista_ucenika.Items.Add($"{noviUcenik.ime} {noviUcenik.prezime} - Odeljenje: {noviUcenik.odeljenje} - Tip mature: {noviUcenik.tipMature}");
            ime_prezime_box.Clear();
            ime_prezime_box.Focus();
        }
    }
}
