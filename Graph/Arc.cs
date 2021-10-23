using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Arc
    {
        public Knot knotOut;
        public Knot knotIn;
        public Arc(Knot knotOut, Knot knotIn)
        {
            this.knotIn = knotIn;
            this.knotOut = knotOut;
        }
    }
}
