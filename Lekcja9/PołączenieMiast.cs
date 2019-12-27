using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    class Para
    {
        public Node n;
        public int odległość;
        public Para (Node n, int odl)
        {
            this.n = n;
            this.odległość = odl;
        }
    }
}
