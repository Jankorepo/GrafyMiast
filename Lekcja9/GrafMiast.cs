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
        public Dictionary<Miasto, PołączenieMiast> odległości;
        public Miasto tmp1 = null, tmp2 = null;
        public List<string> M;
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
            this.odległości = new Dictionary<Miasto, PołączenieMiast>();
            this.AD(start);
            return "Najszybsza droga między miastami  "+start+" i "+koniec+" wynosi " +Convert.ToInt32(odległości[koniec].odległość)+" km";
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
        public void WczytajPlik()
        {
            string[] x = new string[3];
            string[] SpisWszystkichPołączeń = System.IO.File.ReadAllLines("Połączenia.txt");
            foreach (string danePołączenie in SpisWszystkichPołączeń)
            {
                
                x = danePołączenie.Split(',');

                tmp1 = new Miasto(x[0]);
                
                // do poprawki bo Nodes ma po kilka takich samych elementów pomimo uzywania contains
                tmp2 = new Miasto(x[1]);
                if (!this.Nodes.Contains(tmp2))
                    this.Nodes.Add(tmp2);
                if (!this.Nodes.Contains(tmp1))
                    this.Nodes.Add(tmp1);


                this.Krawędzie.Add(new OdległościMiędzyMiastowe(tmp1, tmp2, Convert.ToInt32(x[2])));
            }
        }
    }
}
