using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaOtpornici.BiznisSloj
{
    public abstract class RezistivniElement
    {
        public virtual double Re { get; set; }

        protected RezistivniElement() {  }

        public static explicit operator double(RezistivniElement element)
        {
            
            return element.Re;
        }

        
    }
}
