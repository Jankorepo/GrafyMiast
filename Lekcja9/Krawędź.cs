using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    class Krawędź
    {
        public Node start;
        public Node koniec;
        public int waga = 1;
        public Krawędź(Node start, Node koniec, int waga = 1)
        {
            this.start = start;
            this.koniec = koniec;
            this.waga = waga;
        }
        public override string ToString()
        {
            return $"{this.start}-{this.koniec} ({this.waga})";
        }
        public Node WeźDrugi(Node n)
        {
            return n == this.start ? this.koniec : this.start;
        }

    }
}
