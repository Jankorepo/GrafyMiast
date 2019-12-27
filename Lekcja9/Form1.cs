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
        int wartość, w2, w3, w4,w5,w6;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node nowyWęzeł = new Node(Convert.ToInt32(wartość));
            drzewo.Nodes.Add(nowyWęzeł);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Krawędź łączenie = new Krawędź(drzewo.Nodes[w2], drzewo.Nodes[w3], w4);
            drzewo.Krawędzie.Add(łączenie);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(drzewo.AlgorytmDijkstry(drzewo.Nodes[w5], drzewo.Nodes[w6]));
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            wartość = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            w2 = Convert.ToInt32(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            w3 = Convert.ToInt32(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            w4 = Convert.ToInt32(textBox4.Text);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            w5= Convert.ToInt32(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            w6 = Convert.ToInt32(textBox6.Text);
        }
    }
}

