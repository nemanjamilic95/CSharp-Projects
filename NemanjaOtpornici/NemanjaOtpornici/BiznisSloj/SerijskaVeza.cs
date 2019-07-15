using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaOtpornici.BiznisSloj
{
    public class SerijskaVeza : RezistivnaMreza
    {

        public override double Re
        {
            get
            {
                double zbirOtpornosti = 0;
                foreach (RezistivniElement e in this.lista)
                {
                    zbirOtpornosti += e.Re;
                }
                return zbirOtpornosti;
            } 
        }

    }
}
