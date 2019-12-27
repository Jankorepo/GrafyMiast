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
        Miasto tmp1,tmp2;
        public Form1()
        {
            InitializeComponent();
            Mapa.WczytajPlik();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Mapa.Nodes.Count; i++)
            {
                if (Mapa.Nodes[i].wartość == TextMiasto1.Text)
                    tmp1 = Mapa.Nodes[i];
                if (Mapa.Nodes[i].wartość == TextMiasto2.Text)
                    tmp2 = Mapa.Nodes[i];
            }
            if (tmp1!=null && tmp2!=null)
                MessageBox.Show(Mapa.AlgorytmDijkstry(tmp1,tmp2));
            tmp1 = tmp2 = null;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

