using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graphs
    {
        public void createMyGraph(Tree tr)
        {
            tr.levels = 1;
            tr.countLevels = new List<int> { 1 };
            tr.countLevels[0] = 1;
            tr.knots = new List<Knot> {new Knot(0, 1)};
            tr.rootNum = 0;
            tr.arcs = new List<Arc> { };
        }
        public void AddKnot(Tree tr, int inputKnot)
        {
            if (tr.knots[inputKnot - 1].level == tr.levels)
            {
                tr.levels++;
                tr.countLevels.Add(1);
                tr.knots.Add(new Knot(tr.knots.Count, tr.levels));
                tr.arcs.Add(new Arc(tr.knots[tr.knots.Count - 1], tr.knots[inputKnot - 1]));
            }
            else
            {
                tr.countLevels[tr.knots[inputKnot - 1].level]++;
                tr.knots.Add(new Knot(tr.knots.Count, tr.knots[inputKnot - 1].level + 1));
                tr.arcs.Add(new Arc(tr.knots[tr.knots.Count - 1], tr.knots[inputKnot - 1]));
            }
        }
        public void craeteGraph1(Tree tr)
        {
            tr.levels = 5;
            tr.m = 4;

            tr.countLevels = new List<int> { };

            tr.countLevels.Add(3);
            tr.countLevels.Add(6);
            tr.countLevels.Add(7);
            tr.countLevels.Add(4);
            tr.countLevels.Add(1);

            tr.knots = new List<Knot> { };

            tr.knots.Add(new Knot(0, 1));
            tr.knots.Add(new Knot(1, 1));
            tr.knots.Add(new Knot(2, 1));
            tr.knots.Add(new Knot(3, 2));
            tr.knots.Add(new Knot(4, 2));
            tr.knots.Add(new Knot(5, 2));
            tr.knots.Add(new Knot(6, 2));
            tr.knots.Add(new Knot(7, 2));
            tr.knots.Add(new Knot(8, 2));
            tr.knots.Add(new Knot(9, 3));
            tr.knots.Add(new Knot(10, 3));
            tr.knots.Add(new Knot(11, 3));
            tr.knots.Add(new Knot(12, 3));
            tr.knots.Add(new Knot(13, 3));
            tr.knots.Add(new Knot(14, 3));
            tr.knots.Add(new Knot(15, 3));
            tr.knots.Add(new Knot(16, 4));
            tr.knots.Add(new Knot(17, 4));
            tr.knots.Add(new Knot(18, 4));
            tr.knots.Add(new Knot(19, 4));
            tr.knots.Add(new Knot(20, 5));
          
            tr.rootNum = tr.knots.Count - 1;

            tr.arcs = new List<Arc> { };

            tr.arcs.Add(new Arc(tr.knots[0], tr.knots[4]));
            tr.arcs.Add(new Arc(tr.knots[1], tr.knots[6]));
            tr.arcs.Add(new Arc(tr.knots[2], tr.knots[8]));
            tr.arcs.Add(new Arc(tr.knots[3], tr.knots[9]));
            tr.arcs.Add(new Arc(tr.knots[4], tr.knots[10]));
            tr.arcs.Add(new Arc(tr.knots[5], tr.knots[11]));
            tr.arcs.Add(new Arc(tr.knots[6], tr.knots[12]));
            tr.arcs.Add(new Arc(tr.knots[7], tr.knots[13]));
            tr.arcs.Add(new Arc(tr.knots[8], tr.knots[13]));
            tr.arcs.Add(new Arc(tr.knots[9], tr.knots[17]));
            tr.arcs.Add(new Arc(tr.knots[10], tr.knots[17]));
            tr.arcs.Add(new Arc(tr.knots[11], tr.knots[17]));
            tr.arcs.Add(new Arc(tr.knots[12], tr.knots[18]));
            tr.arcs.Add(new Arc(tr.knots[13], tr.knots[18]));
            tr.arcs.Add(new Arc(tr.knots[14], tr.knots[18]));
            tr.arcs.Add(new Arc(tr.knots[15], tr.knots[19]));
            tr.arcs.Add(new Arc(tr.knots[16], tr.knots[20]));
            tr.arcs.Add(new Arc(tr.knots[17], tr.knots[20]));
            tr.arcs.Add(new Arc(tr.knots[18], tr.knots[20]));
            tr.arcs.Add(new Arc(tr.knots[19], tr.knots[20]));


        }
        public void craeteGraph2(Tree tr)
        {
            tr.levels = 6;
            tr.m = 4;

            tr.countLevels = new List<int> { };

            tr.countLevels.Add(2);
            tr.countLevels.Add(2);
            tr.countLevels.Add(9);
            tr.countLevels.Add(8);
            tr.countLevels.Add(5);
            tr.countLevels.Add(1);

            tr.knots = new List<Knot> { };

            tr.knots.Add(new Knot(0, 1));
            tr.knots.Add(new Knot(1, 1));
            tr.knots.Add(new Knot(2, 2));
            tr.knots.Add(new Knot(3, 2));
            tr.knots.Add(new Knot(4, 3));
            tr.knots.Add(new Knot(5, 3));
            tr.knots.Add(new Knot(6, 3));
            tr.knots.Add(new Knot(7, 3));
            tr.knots.Add(new Knot(8, 3));
            tr.knots.Add(new Knot(9, 3));
            tr.knots.Add(new Knot(10, 3));
            tr.knots.Add(new Knot(11, 3));
            tr.knots.Add(new Knot(12, 3));
            tr.knots.Add(new Knot(13, 4));
            tr.knots.Add(new Knot(14, 4));
            tr.knots.Add(new Knot(15, 4));
            tr.knots.Add(new Knot(16, 4));
            tr.knots.Add(new Knot(17, 4));
            tr.knots.Add(new Knot(18, 4));
            tr.knots.Add(new Knot(19, 4));
            tr.knots.Add(new Knot(20, 4));
            tr.knots.Add(new Knot(21, 5));
            tr.knots.Add(new Knot(22, 5));
            tr.knots.Add(new Knot(23, 5));
            tr.knots.Add(new Knot(24, 5));
            tr.knots.Add(new Knot(25, 5));
            tr.knots.Add(new Knot(26, 6));

            tr.rootNum = tr.knots.Count - 1;

            tr.arcs = new List<Arc> { };

            tr.arcs.Add(new Arc(tr.knots[0], tr.knots[3]));
            tr.arcs.Add(new Arc(tr.knots[1], tr.knots[3]));
            tr.arcs.Add(new Arc(tr.knots[2], tr.knots[7]));
            tr.arcs.Add(new Arc(tr.knots[3], tr.knots[8]));
            tr.arcs.Add(new Arc(tr.knots[4], tr.knots[13]));
            tr.arcs.Add(new Arc(tr.knots[5], tr.knots[15]));
            tr.arcs.Add(new Arc(tr.knots[6], tr.knots[15]));
            tr.arcs.Add(new Arc(tr.knots[7], tr.knots[16]));
            tr.arcs.Add(new Arc(tr.knots[8], tr.knots[17]));
            tr.arcs.Add(new Arc(tr.knots[9], tr.knots[18]));
            tr.arcs.Add(new Arc(tr.knots[10], tr.knots[19]));
            tr.arcs.Add(new Arc(tr.knots[11], tr.knots[19]));
            tr.arcs.Add(new Arc(tr.knots[12], tr.knots[19]));
            tr.arcs.Add(new Arc(tr.knots[13], tr.knots[21]));
            tr.arcs.Add(new Arc(tr.knots[14], tr.knots[21]));
            tr.arcs.Add(new Arc(tr.knots[15], tr.knots[21]));
            tr.arcs.Add(new Arc(tr.knots[16], tr.knots[22]));
            tr.arcs.Add(new Arc(tr.knots[17], tr.knots[23]));
            tr.arcs.Add(new Arc(tr.knots[18], tr.knots[23]));
            tr.arcs.Add(new Arc(tr.knots[19], tr.knots[24]));
            tr.arcs.Add(new Arc(tr.knots[20], tr.knots[24]));
            tr.arcs.Add(new Arc(tr.knots[21], tr.knots[26]));
            tr.arcs.Add(new Arc(tr.knots[22], tr.knots[26]));
            tr.arcs.Add(new Arc(tr.knots[23], tr.knots[26]));
            tr.arcs.Add(new Arc(tr.knots[24], tr.knots[26]));
            tr.arcs.Add(new Arc(tr.knots[25], tr.knots[26]));
        }
        public void craeteGraph3(Tree tr)
        {
            tr.levels = 4;
            tr.m = 3;

            tr.countLevels = new List<int> { };

            tr.countLevels.Add(4);
            tr.countLevels.Add(2);
            tr.countLevels.Add(1);
            tr.countLevels.Add(1);
            
            tr.knots = new List<Knot> { };

            tr.knots.Add(new Knot(0, 1));
            tr.knots.Add(new Knot(1, 1));
            tr.knots.Add(new Knot(2, 1));
            tr.knots.Add(new Knot(3, 1));
            tr.knots.Add(new Knot(4, 2));
            tr.knots.Add(new Knot(5, 2));
            tr.knots.Add(new Knot(6, 3));
            tr.knots.Add(new Knot(7, 4));
            
            tr.rootNum = tr.knots.Count - 1;

            tr.arcs = new List<Arc> { };

            tr.arcs.Add(new Arc(tr.knots[0], tr.knots[4]));
            tr.arcs.Add(new Arc(tr.knots[1], tr.knots[4]));
            tr.arcs.Add(new Arc(tr.knots[2], tr.knots[5]));
            tr.arcs.Add(new Arc(tr.knots[3], tr.knots[5]));
            tr.arcs.Add(new Arc(tr.knots[4], tr.knots[6]));
            tr.arcs.Add(new Arc(tr.knots[5], tr.knots[6]));
            tr.arcs.Add(new Arc(tr.knots[6], tr.knots[7]));

        }
        public void craeteGraph4(Tree tr)
        {
            tr.levels = 9;
            tr.m = 3;

            tr.countLevels = new List<int> { };

            tr.countLevels.Add(1);
            tr.countLevels.Add(1);
            tr.countLevels.Add(3);
            tr.countLevels.Add(3);
            tr.countLevels.Add(3);
            tr.countLevels.Add(3);
            tr.countLevels.Add(3);
            tr.countLevels.Add(4);
            tr.countLevels.Add(1);

            tr.knots = new List<Knot> { };

            tr.knots.Add(new Knot(0, 1));
            tr.knots.Add(new Knot(1, 2));
            tr.knots.Add(new Knot(2, 3));
            tr.knots.Add(new Knot(3, 3));
            tr.knots.Add(new Knot(4, 3));
            tr.knots.Add(new Knot(5, 4));
            tr.knots.Add(new Knot(6, 4));
            tr.knots.Add(new Knot(7, 4));
            tr.knots.Add(new Knot(8, 5));
            tr.knots.Add(new Knot(9, 5));
            tr.knots.Add(new Knot(10, 5));
            tr.knots.Add(new Knot(11, 6));
            tr.knots.Add(new Knot(12, 6));
            tr.knots.Add(new Knot(13, 6));
            tr.knots.Add(new Knot(14, 7));
            tr.knots.Add(new Knot(15, 7));
            tr.knots.Add(new Knot(16, 7));
            tr.knots.Add(new Knot(17, 8));
            tr.knots.Add(new Knot(18, 8));
            tr.knots.Add(new Knot(19, 8));
            tr.knots.Add(new Knot(20, 8));
            tr.knots.Add(new Knot(21, 9));
            
            tr.rootNum = tr.knots.Count - 1;

            tr.arcs = new List<Arc> { };

            tr.arcs.Add(new Arc(tr.knots[0], tr.knots[1]));
            tr.arcs.Add(new Arc(tr.knots[1], tr.knots[3]));
            tr.arcs.Add(new Arc(tr.knots[2], tr.knots[5]));
            tr.arcs.Add(new Arc(tr.knots[3], tr.knots[6]));
            tr.arcs.Add(new Arc(tr.knots[4], tr.knots[6]));
            tr.arcs.Add(new Arc(tr.knots[5], tr.knots[8]));
            tr.arcs.Add(new Arc(tr.knots[6], tr.knots[8]));
            tr.arcs.Add(new Arc(tr.knots[7], tr.knots[9]));
            tr.arcs.Add(new Arc(tr.knots[8], tr.knots[11]));
            tr.arcs.Add(new Arc(tr.knots[9], tr.knots[12]));
            tr.arcs.Add(new Arc(tr.knots[10], tr.knots[13]));
            tr.arcs.Add(new Arc(tr.knots[11], tr.knots[15]));
            tr.arcs.Add(new Arc(tr.knots[12], tr.knots[15]));
            tr.arcs.Add(new Arc(tr.knots[13], tr.knots[16]));
            tr.arcs.Add(new Arc(tr.knots[14], tr.knots[18]));
            tr.arcs.Add(new Arc(tr.knots[15], tr.knots[18]));
            tr.arcs.Add(new Arc(tr.knots[16], tr.knots[20]));
            tr.arcs.Add(new Arc(tr.knots[17], tr.knots[21]));
            tr.arcs.Add(new Arc(tr.knots[18], tr.knots[21]));
            tr.arcs.Add(new Arc(tr.knots[19], tr.knots[21]));
            tr.arcs.Add(new Arc(tr.knots[20], tr.knots[21]));           
        }
    }
}
