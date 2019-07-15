using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaRoboti.BiznisSloj
{
    public abstract class Operacija
    {
        private static int id;
        public Operacija(int id)
        {
           id = ++Operacija.id;
        }
        public abstract void izvrsi();
        public abstract void opozovi();

    }
}
