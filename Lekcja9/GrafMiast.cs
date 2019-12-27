using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    class Graf
    {
        public List<Node> Nodes;
        public List<Krawędź> Krawędzie;
        public List<Node> odwiedzone;
        public List<Node> zwracanieWęzłów;
        public Dictionary<Node, Para> odległości;
        public Graf()
        {
            Nodes = new List<Node>();
            Krawędzie = new List<Krawędź>();
        }
        public List<Krawędź> ZnajdźKrawędzie(Node n)
        {
            return this.Krawędzie.Where(k => k.start == n || k.koniec == n).ToList();
        }
        public string AlgorytmDijkstry(Node start, Node koniec)
        {
            this.odwiedzone = new List<Node>();
            this.zwracanieWęzłów = new List<Node>();
            this.odległości = new Dictionary<Node, Para>();
            this.AD(start);
            this.ZwróćKolejnoWęzły(koniec);
            return "Najszybsza droga między węzłami  "+start+" i "+koniec+"  to: "+string.Join(" ", this.zwracanieWęzłów)
                +" i wynosi ona " +Convert.ToInt32(odległości[koniec].odległość)+" km";
        }
        public void AD(Node n)
        {
            if (this.odwiedzone.Contains(n))
                return;
            if (odwiedzone.Count == 0)
                this.odległości.Add(n, new Para(null, 0));
            this.odwiedzone.Add(n);
            List<Krawędź> kr = this.ZnajdźKrawędzie(n);
            foreach (var k in kr)
            {
                if (!this.odwiedzone.Contains(k.WeźDrugi(n)))
                {
                    if (!odległości.ContainsKey(k.WeźDrugi(n)))
                        this.odległości.Add(k.WeźDrugi(n), new Para(n, k.waga + odległości[n].odległość));
                    else
                        if (this.odległości[k.WeźDrugi(n)].odległość > k.waga + odległości[n].odległość)
                            this.odległości[k.WeźDrugi(n)] = new Para(n, k.waga + odległości[n].odległość);
                }
            }
            foreach (var k in kr)
            {
                if (!this.odwiedzone.Contains(k.WeźDrugi(n)))
                    AD(odległości.OrderBy(x => x.Value.odległość).First(x => !this.odwiedzone.Contains(x.Key)).Key);
            }
        }
        public void ZwróćKolejnoWęzły(Node ostatni)
        {
            zwracanieWęzłów.Add(ostatni);
            Node poprzednik = this.odległości[ostatni].n;
            if (poprzednik != null)
                ZwróćKolejnoWęzły(poprzednik);
            else
                zwracanieWęzłów.Reverse();
        }
    }
}
