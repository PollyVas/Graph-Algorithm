using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Knot
    {
        public int number;
        public int level;
        public int place;
        public int mark;
        public int x;
        public int y;
        public bool changed;
        //public bool root;
        public Knot() { }
        public Knot(int number, int level)
        {
            this.number = number;
            this.level = level;
        }
    }
}
