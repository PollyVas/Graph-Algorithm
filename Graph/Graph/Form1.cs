using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Tree myTr;
        void showKnot(Graphics g, Tree tr, int number, int x, int y)
        {
            g.DrawEllipse(Pens.Red, x-20, y-20, 40, 40);
            if (number < 9)
            {
                g.DrawString((number + 1).ToString(), this.Font, Brushes.Black, x - 4, y - 6);   
            }
            else
            {
                g.DrawString((number + 1).ToString(), this.Font, Brushes.Black, x - 8, y - 6);           
            }
            //g.DrawString((tr.knots[number].mark + 1).ToString(), this.Font, Brushes.Black, x + 20, y - 20);
            //g.DrawString((tr.knots[number].place + 1).ToString(), this.Font, Brushes.Black, x - 25, y - 25);
        }
        void showArrow(Graphics g, Tree tr, int number)
        {
            Pen pen = new Pen(Color.Red, 3);
            pen.CustomEndCap = new AdjustableArrowCap(3, 3);
            g.DrawLine(pen, tr.arcs[number].knotOut.x, tr.arcs[number].knotOut.y + 20, tr.arcs[number].knotIn.x, tr.arcs[number].knotIn.y - 20);
            //g.DrawString(Convert.ToString(number).ToString(), this.Font, Brushes.Blue, (tr.arcs[number].knotOut.x + tr.arcs[number].knotIn.x) / 2, (tr.arcs[number].knotOut.y + tr.arcs[number].knotIn.y) / 2);
        }
        void showGraph(Tree tr)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            int height = pictureBox1.Height / (tr.levels + 1);
            int width;          
            int count = 0;
            for (int i = 0; i < tr.levels; i++)
            {                
                width = pictureBox1.Width / (tr.countLevels[i] + 1);
                for (int j = 0; j < tr.countLevels[i]; j++)
                {
                    tr.knots[count].x = width * (j + 1);
                    tr.knots[count].y = height * (i + 1);                
                    showKnot(g, tr, count, tr.knots[count].x, tr.knots[count].y);
                    count++;
                }
            }
            for (int i = 0; i < tr.arcs.Count; i++)
            {
                showArrow(g, tr, i);
            }
            listBox1.Items.Clear();
            string str = "";
            for (int i = 0; i <= tr.knots[tr.knots.Count - 1].place; i++)
            {
                str = (i + 1).ToString() + ": ";
                for (int j = 0; j < tr.knots.Count; j++)
                {
                    if (tr.knots[j].place == i)
                    {
                        str += (tr.knots[j].number + 1) + ", ";
                    }
                }
                listBox1.Items.Add(str);
            }
        }        

        private void Button1_Click(object sender, EventArgs e)
        {
            Graphs gr = new Graphs();
            Tree tr = new Tree();
            gr.craeteGraph1(tr);
            tr.fillMatrixOfAdjacency();
            tr.putMarks();
            tr.putPlaces();
            showGraph(tr);
            label2.Text = tr.m.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Graphs gr = new Graphs();
            Tree tr = new Tree();
            gr.craeteGraph2(tr);
            tr.fillMatrixOfAdjacency();
            tr.putMarks();
            tr.putPlaces();
            showGraph(tr);
            label2.Text = tr.m.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Graphs gr = new Graphs();
            Tree tr = new Tree();
            gr.craeteGraph3(tr);
            tr.fillMatrixOfAdjacency();
            tr.putMarks();
            tr.putPlaces();
            showGraph(tr);
            label2.Text = tr.m.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Graphs gr = new Graphs();
            Tree tr = new Tree();
            gr.craeteGraph4(tr);
            tr.fillMatrixOfAdjacency();
            tr.putMarks();
            tr.putPlaces();
            showGraph(tr);
            label2.Text = tr.m.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            button6.Enabled = true;
            button7.Enabled = true;
            Graphs gr = new Graphs();
            myTr = new Tree();
            gr.createMyGraph(myTr);
            showGraph(myTr);
            groupBox1.Visible = true;
            comboBox1.Items.Add(1);
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            try {
                int inputKnot = int.Parse(comboBox1.SelectedItem.ToString());
                Graphs gr = new Graphs();
                gr.AddKnot(myTr, inputKnot);
                showGR(myTr);
                comboBox1.Items.Add(myTr.knots.Count);

            } catch (Exception exp)
            {
                MessageBox.Show("Оберіть дугу зі списку");
            }         
        }
        void showGR(Tree tr)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            int height = pictureBox1.Height / (tr.levels + 1);
            int width;
            int count = 0;
            for (int i = 0; i < tr.levels; i++)
            {
                width = pictureBox1.Width / (tr.countLevels[tr.levels - i - 1] + 1);
                count = 0;
                for (int j = 0; j < tr.knots.Count; j++)
                {
                    if (tr.knots[j].level == tr.levels - i)
                    {
                        tr.knots[j].x = width * (count + 1);
                        tr.knots[j].y = height * (i + 1);
                        count++;
                        showKnot(g, tr, tr.knots[j].number, tr.knots[j].x, tr.knots[j].y);
                    }                    
                }
            }
            for (int i = 0; i < tr.arcs.Count; i++)
            {
                showArrow(g, tr, i);
            }           
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button7.Enabled = false;
            try
            {
                myTr.m = int.Parse(textBox1.Text);
                if (myTr.m < 2)
                {
                    MessageBox.Show("Неправильне введення m");
                }
                else
                {
                    myTr.fillMatrixOfAdjacency();
                    myTr.putMarks();
                    myTr.putPlaces();
                    showGR(myTr);
                    label2.Text = myTr.m.ToString();

                    listBox1.Items.Clear();

                    string str = "";

                    for (int i = 0; i <= myTr.knots[myTr.rootNum].place; i++)
                    {
                        str = (i + 1).ToString() + ": ";
                        for (int j = 0; j < myTr.knots.Count; j++)
                        {
                            if (myTr.knots[j].place == i)
                            {
                                str += (myTr.knots[j].number + 1) + ", ";
                            }
                        }
                        listBox1.Items.Add(str);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Неправильне введення m");
            }
           
        }
    }
}
