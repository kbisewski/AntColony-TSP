using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntColonyTSP
{
    public partial class Form1 : Form
    {
        private Boolean antsAreGoing = false;
        private List<Point> points = new List<Point>();
        private List<PictureBox> pointsPic = new List<PictureBox>();
        private Graph graph;
        private Ant[] ants;
        private Random r = new Random();
        private List<Edge> shortestWay = new List<Edge>();
        private double shortestWayLength = -1;

        private String type = "cycle";
        private double alfa, beta;
        private int cyclesNumber;
        private double q1;
        private double q2;
        private double q3;
        public double initPheromone;
        public double remainingPheromone;

        public Form1()
        {
            InitializeComponent();

        }

        private void go()
        {
            graph = new Graph(points, initPheromone, remainingPheromone);
            ants = new Ant[points.Count()];
            for (int i = 0; i < ants.Length; i++)
            {
                ants[i] = new Ant(graph, points[i], alfa, beta, q1, q2, q3, type, r);
            }


            for (int i = 0; i < cyclesNumber; i++)
            {
                doCycle();

                graph.updatePheromone();
                drawBestWay();
            }

        }

        private void doCycle()
        {

            Parallel.ForEach(ants, ant =>
            {
                List<Edge> visitedEdges = ant.doCycle();
                checkWay(visitedEdges);
            });
        }

        private void checkWay(List<Edge> visitedEdges)
        {
            double length = calcLength(visitedEdges);
            if (length < shortestWayLength || shortestWayLength == -1)
            {
                shortestWayLength = length;
                shortestWay = visitedEdges;
            }
        }

        private double calcLength(List<Edge> edges)
        {
            double length = 0;
            foreach (Edge edge in edges)
            {
                length += edge.distance;
            }
            return length;
        }

        private void drawBestWay()
        {
                lengthValueLabel.Text = shortestWayLength + "";
                panel.Refresh();
        }

        private void updatePheromoneAfterCycle()
        {
            if (type.Equals("cycle"))
            {
                graph.updatePheromone();
            }

        }

        private void panel_Click(object sender, EventArgs e)
        {
            if (!antsAreGoing)
            {
                int x = MousePosition.X - this.Location.X - panel.Location.X - 7;
                int y = MousePosition.Y - this.Location.Y - panel.Location.Y - 31;
                Point point = new Point(x, y);
                if (!points.Contains(point))
                {
                    points.Add(point);
                    drawPoint(point);
                    pointsAmountLabel.Text = points.Count() + "";
                    panel.Refresh();
                }
                clearButton.Enabled = true;
                if (points.Count() > 3 && listBox.SelectedIndex != -1)
                {
                    button1.Enabled = true;
                }
            }

        }

        private void drawPoint(Point point)
        {
            PictureBox p = new PictureBox();
            pointsPic.Add(p);
            p.Width = 5;
            p.Height = 5;
            p.BackColor = Color.Black;

            panel.Controls.Add(p);
            p.Show();
            p.BringToFront();
            p.Left = point.X;
            p.Top = point.Y;
        }

        private void drawLine(Point a, Point b, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(150, 0, 0, 0), 1);
            e.Graphics.DrawLine(pen, a, b);
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            panel.Invalidate();
            foreach (Edge edge in shortestWay)
            {
                drawLine(edge.a, edge.b, e);
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            int x = MousePosition.X - this.Location.X - panel.Location.X - 7;
            int y = MousePosition.Y - this.Location.Y - panel.Location.Y - 31;
            showMousePosition(x, y);
        }

        private void showMousePosition(int x, int y)
        {
            if (x > 260 && x < 271 && y > 54 && y < 64)
            {
                mousePositionLabel.Text = "Elbląg";
            }
            else if (x > 199 && x < 212 && y < 4)
            {
                mousePositionLabel.Text = "Karwia";
            }
            else if (x > 223 && x < 232 && y > 40 && y < 49)
            {
                mousePositionLabel.Text = "Gdańsk";
            }
            else if (x > 217 && x < 223 && y > 28 && y < 35)
            {
                mousePositionLabel.Text = "Gdynia";
            }
            else if (x > 230 && x < 240 && y > 62 && y < 67)
            {
                mousePositionLabel.Text = "Tczew";
            }
            else
            {
                mousePositionLabel.Text = x + ", " + y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!antsAreGoing)
            {
                antsAreGoing = true;
                panel.Refresh();
                initParameters();
                button1.Enabled = false;
                shortestWayLength = -1;
                lengthValueLabel.Text = 0 + "";

                Thread antsThread = new Thread(go);
                antsThread.Start();
                //go();
                panel.Refresh();
                button1.Enabled = true;
                antsAreGoing = false;
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pointsPic.Count; i++)
            {
                PictureBox p = pointsPic[i];
                p.Visible = false;
                this.Controls.Remove(p);
            }
            pointsPic.Clear();
            points.Clear();
            shortestWay.Clear();
            panel.Refresh();
            pointsAmountLabel.Text = 0 + "";
            lengthValueLabel.Text = "";
            button1.Enabled = false;
            clearButton.Enabled = false;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            mousePositionLabel.Text = "";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = listBox.SelectedItem.ToString();
            switch (type)
            {
                case "cycle": changeQUpDowns(false, false, true); break;
                case "density": changeQUpDowns(true, false, false); break;
                case "quantity": changeQUpDowns(false, true, false); break;

            }
            if (listBox.SelectedIndex != -1 && points.Count() > 3)
            {
                button1.Enabled = true;
            }
        }

        private void changeQUpDowns(bool Q1, bool Q2, bool Q3)
        {
            Q1UpDown.Enabled = Q1;
            Q2UpDown.Enabled = Q2;
            Q3UpDown.Enabled = Q3;
        }

        private void initParameters()
        {
            this.alfa = (double)alfaUpDown.Value;
            this.beta = (double)betaUpDown.Value;
            this.cyclesNumber = (int)cyclesUpDown.Value;
            this.q1 = (double)Q1UpDown.Value;
            this.q2 = (double)Q2UpDown.Value;
            this.q3 = (double)Q3UpDown.Value;
            this.initPheromone = (double)initPheromoneUpDown.Value;
            this.remainingPheromone = (double)(remainingPheromoneUpDown.Value / 100);
        }
    }
}
