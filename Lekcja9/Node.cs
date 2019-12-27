using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    class Node
    {
        public string wartość;
        public Node(string wartość)
        {
            this.wartość = wartość;
        }
        public override string ToString()
        {
            return this.wartość;
        }
    }
}
