using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokvijumNas.BiznisSloj
{
   public abstract class BiznisKlase
    {

       
    }

    public class BStudent : BiznisKlase {


        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string IndeksCalc { get; set; }

    }

    public class BPredmeti : BiznisKlase
    {
       public int IdPredmet { get; set; }
       public string PredmetNaziv { get; set; }

    }
    public class BIspitniRok : BiznisKlase
    {
       
        public int IdIspit { get; set; }
        public string PredmetNaziv { get; set; }
        public string IspitniRok { get; set; }
        public int Godina { get; set; }
    }
    public class BStudentiNaIspitu : BiznisKlase
    {
        public string ImePrezime { get; set; }
        public string Index { get; set; }
        public int? Ocena { get; set; }

    }

}
