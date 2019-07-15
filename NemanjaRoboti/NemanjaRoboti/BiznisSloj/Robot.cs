using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaRoboti.BiznisSloj
{
    public class Pozicija
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

       
    }
    public class Robot
    {
        public Pozicija pozicija = new Pozicija();
        private string ime;

        public string Ime { get => ime; }

        public Robot() { }

        public Robot(string ime, Pozicija pozicija)
        {
            this.ime = ime;
            this.pozicija = new Pozicija { X=pozicija.X,Y=pozicija.Y,Z=pozicija.Z};
        }


    }
}
