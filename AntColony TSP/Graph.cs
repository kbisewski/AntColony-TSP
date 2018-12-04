using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyTSP
{
    public class Graph
    {
        public List<Point> points;
        public List<Edge> edges = new List<Edge>();
        public int amountOfPoints { get { return points.Count(); } }

        public Graph(List<Point> points, double initPheromone, double remainingPheromone)
        {
            this.points = points;

            for (int i = 0; i < points.Count(); i++)
            {
                for (int j = 0; j < points.Count(); j++)
                {
                    if ( ! points[i].Equals(points[j]))
                    {
                        Edge edge = new Edge(points[i], points[j], initPheromone, remainingPheromone);
                        if( ! exist(edge) )
                        {
                            edges.Add(edge);
                        }
                    }

                }
            }
        }

        private bool exist(Edge edge)
        {
            bool exist = false;
            for (int k = 0; k < edges.Count(); k++)
            {
                if (edges[k].equals(edge))
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

        public Edge[] edgesFrom(Point point)
        {
            Edge[] edgesFromPoint = new Edge[amountOfPoints - 1];
            int i = 0;
            foreach(Edge edge in edges)
            {
                if(edge.contain(point))
                {
                    edgesFromPoint[i] = edge;
                    i++;
                    if(i == amountOfPoints - 1)
                    {
                        break;
                    }
                }
            }
            return edgesFromPoint;
        }

        public void updatePheromone()
        {
            foreach(Edge edge in edges)
            {
                edge.updatePheromone();
            }
        }

    }
}
