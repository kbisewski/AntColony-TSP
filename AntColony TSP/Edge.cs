using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyTSP
{
    public class Edge
    {
        public Point a { get; }
        public Point b { get; }
        public double distance { get; }
        public double pheromone { get; set; }
        public double deltaPheromone = 0;
        public double remainingPheromone;

        public Edge(Point a, Point b, double initPheromone, double remainingPheromone)
        {
            this.a = a;
            this.b = b;

            double x = Math.Pow(a.X - b.X, 2);
            double y = Math.Pow(a.Y - b.Y, 2);
            this.distance = Math.Sqrt(x + y);

            this.pheromone = initPheromone;
            this.remainingPheromone = remainingPheromone;
        }

        public bool contain(Point point)
        {
            if(a.Equals(point) || b.Equals(point))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public Point getAnotherPoint(Point point)
        {
            if(a.Equals(point))
            {
                return b;
            } else
            {
                return a;
            }
        }

        public void increaseDelta(double addedPheromone)
        {
            deltaPheromone += addedPheromone;
        }

        public void updatePheromone()
        {
            pheromone = remainingPheromone * pheromone + deltaPheromone;
            deltaPheromone = 0;
        }

        public bool equals(Edge e)
        {
            if( (a.Equals(e.a) && b.Equals(e.b)) || (a.Equals(e.b) && b.Equals(e.a)) )
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
