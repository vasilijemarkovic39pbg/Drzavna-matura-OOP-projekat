using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Drzavna_matura
{
    public enum TipMature { Opsta, Strucna, Umetnicka }

    public class Ucenik
    {
        public string odeljenje { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public TipMature tipMature { get; set; }
        public string JezikPolaganja { get; set; }
        public string PrviPredmet { get; set; } // maternji jezik
        public string DrugiPredmet { get; set; } // uvek mata
        public string TreciPredmet { get; set; } // bira se

        public Ucenik() { }
        public string getUneto()
        { return $"{odeljenje},{ime} {prezime},{tipMature},{JezikPolaganja},{PrviPredmet},{DrugiPredmet},{TreciPredmet}"; }
    }

    public class ProfilSema
    {
        public string NazivProfila { get; set; } // tipa gimnazija ili strucna
        public string odeljenje {get; set;}
        public TipMature tipMature { get; set; }
        public string JezikPolaganja { get; set; }
        public string PrviPredmet { get; set; } // maternji jezik
        public string DrugiPredmet { get; set; } // uvek mata
        public string TreciPredmet { get; set; } // bira se

        public string getUneto()
        { return $"{NazivProfila},{odeljenje},{tipMature},{JezikPolaganja},{PrviPredmet},{DrugiPredmet},{TreciPredmet}"; }
    }

    internal class Modeli
    {
    }
}
