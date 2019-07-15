using NemanjaOtpornici.BiznisSloj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NemanjaOtpornici
{
    public partial class Form1 : Form
    {
        private RezistivnaMreza mreza = new RezistivnaMreza();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otpornik R1= new Otpornik(12, Vrsta.ugljenoslojni);
            Otpornik R2 = new Otpornik(4, Vrsta.ugljenoslojni);
            Otpornik R3 = new Otpornik(11, Vrsta.ugljenoslojni);
            Otpornik R4 = new Otpornik(6, Vrsta.ugljenoslojni);

            SerijskaVeza serijska = new SerijskaVeza();
            serijska.dodaj(R1);
            ParalelnaVeza paralelna = new ParalelnaVeza();
            paralelna.dodaj(R2);
            SerijskaVeza serijska2 = new SerijskaVeza();
            serijska2.dodaj(R3);
            serijska2.dodaj(R4);
            paralelna.dodaj(serijska2);
            serijska.dodaj(paralelna);

            double otpornostMreze = serijska.Re;

            RezistivniElement rez=serijska.dohvati(1);
            Console.WriteLine(rez);
        }
    }
}
