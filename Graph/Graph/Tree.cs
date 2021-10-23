using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Tree
    {
        public List<Knot> knots;
        public List<Arc> arcs;
        public int m;
        public int rootNum;
        public int levels;
        public List<int> countLevels;
        public int[,] matrixOfAdjacency;

        public void fillMatrixOfAdjacency()
        {
            matrixOfAdjacency = new int[knots.Count, knots.Count];
            for (int i = 0; i < knots.Count; i++)
            {
                knots[i].mark = -1;
                knots[i].place = -1;
                knots[i].changed = false;
                for (int j = 0; j < knots.Count; j++)
                {
                    matrixOfAdjacency[i, j] = 0;
                }
            }
            for (int i = 0; i < arcs.Count; i++)
            {
                matrixOfAdjacency[arcs[i].knotOut.number, arcs[i].knotIn.number] = 1;
            }
        }
        public void putMarks()
        {
            bool isFilled = true;
            bool[] putInRow = new bool[knots.Count];
            bool contin = false;
            int count = 0;
            while (isFilled)
            {
                contin = false;
                for (int j = 0; j < knots.Count; j++)
                {
                    putInRow[j] = true;
                    if (knots[j].mark == -1)
                    {
                        for (int i = 0; i < knots.Count; i++)
                        {
                            if (knots[i].mark == -1 && matrixOfAdjacency[i, j] == 1)
                            {
                                putInRow[j] = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        putInRow[j] = false;
                    }
                }
                for(int i = 0; i < knots.Count; i++)
                {
                    if (putInRow[i] == true)
                    {
                        contin = true;
                        knots[i].mark = count;
                    }
                }
                count++;
                isFilled = contin;
            }
        }
        public void deleteOne(List<int> numbers, int place)
        {
            int max = place;
            int num = rootNum;
            for (int i = 0; i < arcs.Count; i++)
            {
                if (numbers.Contains(arcs[i].knotOut.number) && max < arcs[i].knotIn.mark)
                {
                    max = arcs[i].knotIn.mark;
                    num = arcs[i].knotOut.number;
                }
            }
            if (max > place + 1)
            {
                knots[num].mark++;
                knots[num].changed = true;
            }
            else
            {
                if (num == rootNum)
                {
                    knots[rootNum].mark++;
                }
                else
                {
                    List<int> numbersNext = new List<int> { };
                    for (int i = 0; i < knots.Count; i++)
                    {
                        if (knots[i].mark == place + 1 && !knots[i].changed)
                        {
                            numbersNext.Add(i);
                        }
                    }
                    deleteOne(numbersNext, place + 1);
                    deleteOne(numbers, place);
                }
            }

        }
        public List<int> chooseKnots(List<int> numbers, int place)
        {
            
            while (numbers.Count > m)
            {
                deleteOne(numbers, place);
                numbers = new List<int> { };
                for (int i = 0; i < knots.Count; i++)
                {
                    if (knots[i].mark == place)
                    {
                        numbers.Add(i);
                    }
                }
            }
            return numbers;
        }
        public void putPlaces()
        {
            int place = 0;          
            List<int> numbers;
            while (knots[rootNum].place == -1)
            {
                numbers = new List<int> { };             
                for (int i = 0; i < knots.Count; i++)
                {
                    knots[i].changed = false;
                    if (knots[i].mark == place)
                    {                  
                        numbers.Add(i);
                    }
                }
                if (numbers.Count > m)
                {
                    numbers = chooseKnots(numbers, place);
                }               
                for (int i = 0; i < numbers.Count; i++)
                {
                    knots[numbers[i]].place = place;
                }               
                place++;
            }
        }
    }
}
