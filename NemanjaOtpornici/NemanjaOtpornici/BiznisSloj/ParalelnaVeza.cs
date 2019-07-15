using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaOtpornici.BiznisSloj
{
    public class ParalelnaVeza:RezistivnaMreza
    {
        public override double Re
        {
            get
            {
                double otpornost = 0;
                foreach (RezistivniElement rez in this.lista)
                {
                    otpornost += 1 / rez.Re;
                }
                double rezultat = 1 / otpornost;
                return rezultat;
            }
        }
    }
}
