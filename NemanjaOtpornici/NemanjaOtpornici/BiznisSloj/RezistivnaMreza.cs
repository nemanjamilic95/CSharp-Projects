using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaOtpornici.BiznisSloj
{
    public class RezistivnaMreza : RezistivniElement
    {
        public List<RezistivniElement> lista = new List<RezistivniElement>();

        public int brojElemenata(RezistivniElement elem)
        {
           
                return this.lista.Count;
            
        }

        public void dodaj(RezistivniElement rez)
        {
            if (rez.Re <= 0 || rez==null)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.lista.Add(rez);
            }

              
        }

        public RezistivniElement dohvati(int i)
        {
            
            if (i < 0 || i >= this.lista.Count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
               return this.lista.ElementAt(i);
            }
        }
    }
}
