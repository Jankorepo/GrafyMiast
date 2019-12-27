using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    class PołączenieMiast
    {
        public Miasto n;
        public int odległość;
        public PołączenieMiast (Miasto n, int odl)
        {
            this.n = n;
            this.odległość = odl;
        }
    }
}
