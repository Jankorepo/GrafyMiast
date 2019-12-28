using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    class GrafMiast
    {
        public List<Miasto> Nodes;
        public List<OdległościMiędzyMiastowe> Krawędzie;
        public List<Miasto> odwiedzone;
        public List<Miasto> zwracanieWęzłów;
        public Dictionary<Miasto, PołączenieMiast> odległości;
        public GrafMiast()
        {
            Nodes = new List<Miasto>();
            Krawędzie = new List<OdległościMiędzyMiastowe>();
        }
        public List<OdległościMiędzyMiastowe> ZnajdźKrawędzie(Miasto n)
        {
            return this.Krawędzie.Where(k => k.start == n || k.koniec == n).ToList();
        }
        public string AlgorytmDijkstry(Miasto start, Miasto koniec)
        {
            this.odwiedzone = new List<Miasto>();
            this.zwracanieWęzłów = new List<Miasto>();
            this.odległości = new Dictionary<Miasto, PołączenieMiast>();
            this.AD(start);
            this.ZwróćKolejnoWęzły(koniec);
            return "Najszybsza droga między miastami  " + start + " i " + koniec + "  to: " + string.Join("-", this.zwracanieWęzłów)
                + " i wynosi ona " + Convert.ToInt32(odległości[koniec].odległość) + " km";
        }
        public void AD(Miasto n)
        {
            if (this.odwiedzone.Contains(n))
                return;
            if (odwiedzone.Count == 0)
                this.odległości.Add(n, new PołączenieMiast(null, 0));
            this.odwiedzone.Add(n);
            List<OdległościMiędzyMiastowe> kr = this.ZnajdźKrawędzie(n);
            foreach (var k in kr)
            {
                if (!this.odwiedzone.Contains(k.WeźDrugi(n)))
                {
                    if (!odległości.ContainsKey(k.WeźDrugi(n)))
                        this.odległości.Add(k.WeźDrugi(n), new PołączenieMiast(n, k.waga + odległości[n].odległość));
                    else
                        if (this.odległości[k.WeźDrugi(n)].odległość > k.waga + odległości[n].odległość)
                        this.odległości[k.WeźDrugi(n)] = new PołączenieMiast(n, k.waga + odległości[n].odległość);
                }
            }
            foreach (var k in kr)
            {
                if (!this.odwiedzone.Contains(k.WeźDrugi(n)))
                    AD(odległości.OrderBy(x => x.Value.odległość).First(x => !this.odwiedzone.Contains(x.Key)).Key);
            }
        }
        public void ZwróćKolejnoWęzły(Miasto ostatni)
        {
            zwracanieWęzłów.Add(ostatni);
            Miasto poprzednik = this.odległości[ostatni].n;
            if (poprzednik != null)
                ZwróćKolejnoWęzły(poprzednik);
            else
                zwracanieWęzłów.Reverse();
        }
    }
}
