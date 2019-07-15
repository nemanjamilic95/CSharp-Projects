using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaOtpornici.BiznisSloj
{
    public enum Vrsta { ugljenoslojni, metalfilm, folijski, zicani, film };
    public class Otpornik : RezistivniElement
    {
        private double r;

        private Vrsta vrsta;


        public double R { get => r; set => r = value; }

        public override double Re
        {
            get
            {
                return this.R;
            }
        }

        public Vrsta Vrsta { get => vrsta; set => vrsta = value; }

        public static implicit operator Otpornik(double d)
        {
            return new Otpornik(d,Vrsta.ugljenoslojni);
        } 


        public Otpornik(double r,Vrsta vrsta)
            
        {
            this.r = r;
            this.Vrsta = vrsta;
        }
    }
}
