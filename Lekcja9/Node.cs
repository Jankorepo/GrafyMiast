using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9
{
    class Node
    {
        public int wartość;
        public Node(int wartość)
        {
            this.wartość = wartość;
        }
        public override string ToString()
        {
            return this.wartość.ToString();
        }
    }
}
