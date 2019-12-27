using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja9
{
    public partial class Form1 : Form
    {
        
        
        GrafMiast Mapa = new GrafMiast();
        string wartość1,wartość2;
        Miasto tmp1,tmp2;
        string gdzieJestBłąd = "";
        public Form1()
        {
            InitializeComponent();
            WczytajPliki();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Mapa.Nodes.Count; i++)
            {
                if (Mapa.Nodes[i].wartość == wartość1)
                    tmp1 = Mapa.Nodes[i];
                if (Mapa.Nodes[i].wartość == wartość2)
                    tmp2 = Mapa.Nodes[i];
            }
            if (gdzieJestBłąd != "")
            MessageBox.Show("Brak miasta lub literówa w nazwie! Linijka z błędem: "+ gdzieJestBłąd);
            else
            MessageBox.Show(Mapa.AlgorytmDijkstry(tmp1,tmp2));
        }


        public void WczytajPliki()
        {
            string[] miasta = System.IO.File.ReadAllLines("Miasta.txt");
            foreach (var tmpMiasto in miasta)
            {
                Mapa.Nodes.Add(new Miasto(tmpMiasto));
            }
            string[] x = new string[3];
            string[] SpisWszystkichPołączeń = System.IO.File.ReadAllLines("Połączenia.txt");
            foreach (string danePołączenie in SpisWszystkichPołączeń)
            {
                x = danePołączenie.Split(',');

                for (int i = 0; i < Mapa.Nodes.Count; i++)
                {
                    if (Mapa.Nodes[i].wartość == x[0])
                        tmp1 = Mapa.Nodes[i];
                    if (Mapa.Nodes[i].wartość == x[1])
                        tmp2 = Mapa.Nodes[i];
                }
                if (tmp1 != null && tmp2 != null)
                    Mapa.Krawędzie.Add(new OdległościMiędzyMiastowe(tmp1, tmp2, Convert.ToInt32(x[2])));
                else
                    gdzieJestBłąd = danePołączenie;
                tmp1 = tmp2 = null;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            wartość1 = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            wartość2 = textBox6.Text;
        }
    }
}

