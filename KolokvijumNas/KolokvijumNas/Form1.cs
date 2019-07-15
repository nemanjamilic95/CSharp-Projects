using KolokvijumNas.BiznisSloj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolokvijumNas
{
    public partial class Form1 : Form
    {
        BiznisLogika biznis = new BiznisLogika();
        //int idPredmet;

        public Form1()
        {

            InitializeComponent();
            BPredmeti[] niz = this.biznis.dohvatiPredmete();
            this.comboBox1.ValueMember = "IdPredmet";
            this.comboBox1.DisplayMember = "PredmetNaziv";
            this.comboBox1.DataSource = niz;
            this.comboBox1.SelectedIndex = -1;
            // this.comboBox1.SelectedValue;
            // BStudentiNaIspitu[] niz1 = this.biznis.dohvatiStudente(2,2);
            // dataGridView1.DataSource = niz1;


        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPredmet;
            if (comboBox1.SelectedValue == null)
                idPredmet = 0;
            else { 
            idPredmet = (int)comboBox1.SelectedValue;
            }
            BIspitniRok[] niz = biznis.dohvatiRokove(idPredmet);
            this.listView1.Items.Clear();
            foreach (BIspitniRok item in niz)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.IdIspit.ToString();
                lvi.SubItems.Add(item.PredmetNaziv);
                lvi.SubItems.Add(item.IspitniRok);
                lvi.SubItems.Add(item.Godina.ToString());
                

                
                this.listView1.Items.Add(lvi);                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
                return;
            
            int idIspit=Int32.Parse(this.listView1.SelectedItems[0].Text);
           BStudentiNaIspitu[] niz1 = this.biznis.dohvatiStudente(idIspit);
            dataGridView1.DataSource = niz1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            biznis.upisiStudenta("Nemanja", "Milic", 169, 2014);


            this.dataGridView1.DataSource = biznis.dohvati();
        }
    }
}
