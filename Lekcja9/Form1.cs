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
        
        
        Graf drzewo = new Graf();
        string w1, w2, w3,w5,w6;
        int w4, x;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node nowyWęzeł = new Node(w1);
            drzewo.Nodes.Add(nowyWęzeł);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drzewo.Nodes.Count; i++)
            {
                x = i;
                if (drzewo.Nodes[i] == w2)
                    break;
            }
            Krawędź łączenie = new Krawędź(drzewo.Nodes[w2], drzewo.Nodes[w3], w4);
            drzewo.Krawędzie.Add(łączenie);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(drzewo.AlgorytmDijkstry(drzewo.Nodes[w5], drzewo.Nodes[w6]));
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            w1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            w2 = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            w3 = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            w4 = textBox4.Text;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            w5= textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            w6 =textBox6.Text;
        }
    }
}

