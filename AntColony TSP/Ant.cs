using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyTSP
{
    class Ant
    {
        private Graph graph;
        private Point startPoint;
        private Point currentPoint;

        private Point[] tabu;
        private int position = 0;
        private List<Edge> visitedEdges = new List<Edge>();
        private double alfa, beta;
        private Random r;
        private double cycleLength = 0;
        private string type;
        private double q1;
        private double q2;
        private double q3;

        public int tabuLength { get { return tabu.Length; } }

        public Ant(Graph graph, Point startPoint, double alfa, double beta, double q1, double q2, double q3, string type, Random r)
        {
            this.graph = graph;
            this.startPoint = startPoint;
            this.currentPoint = startPoint;
            this.tabu = new Point[graph.amountOfPoints];
            this.tabu[0] = startPoint;
            this.alfa = alfa;
            this.beta = beta;
            this.q1 = q1;
            this.q2 = q2;
            this.q3 = q3;
            this.type = type;
            this.r = r;
        }

        public List<Edge> doCycle()
        {
            reset();
            for (int i = 1; i < graph.amountOfPoints; i++)
            {
                step();
            }
            Edge lastEdge = getLastEdge();
            cycleLength += lastEdge.distance;
            visitedEdges.Add(lastEdge);
            updatePheromoneAfterStep();
            increaseDeltaAfterCycle();
            return visitedEdges;
        }

        public void step()
        {
            Edge[] edges = graph.edgesFrom(currentPoint);
            Edge[] posibleEdges = getPosibleEdges(edges, tabu);
            double[] edgesProbability = getEdgesProbability(posibleEdges);
            Edge choice = randomEdge(posibleEdges, edgesProbability);

            this.cycleLength += choice.distance;
            this.currentPoint = choice.getAnotherPoint(currentPoint);
            position++;
            tabu[position] = currentPoint;
            this.visitedEdges.Add(choice);
            updatePheromoneAfterStep();
        }

        private Edge[] getPosibleEdges(Edge[] edges, Point[] tabu)
        {
            List<Edge> posibleEdges = new List<Edge>();
            for (int i = 0; i < edges.Length; i++)
            {
                if (!tabu.Contains(edges[i].getAnotherPoint(currentPoint)))
                {
                    posibleEdges.Add(edges[i]);
                }
            }
            return posibleEdges.ToArray<Edge>();
        }

        private Edge randomEdge(Edge[] posibleEdges, double[] edgesProbability)
        {
            double sum = 0;
            double randNum = r.NextDouble();
            Edge choice = posibleEdges[0];  //----------------------
            for (int i = 0; i < edgesProbability.Length; i++)
            {
                sum += edgesProbability[i];
                if (randNum < sum)
                {
                    choice = posibleEdges[i];
                    break;
                }
            }
            return choice;
        }

        private double[] getEdgesProbability(Edge[] posibleEdges)
        {
            double[] edgesProbability = new double[posibleEdges.Length];
            double sum = 0;
            for (int i = 0; i < posibleEdges.Length; i++)
            {
                double tauAlfa = Math.Pow(posibleEdges[i].pheromone, alfa);
                double criterionFunctionBeta = Math.Pow(1 / posibleEdges[i].distance, beta);
                double tempProbability = tauAlfa * criterionFunctionBeta;
                edgesProbability[i] = tempProbability;
                sum += tempProbability;
            }

            for (int i = 0; i < edgesProbability.Length; i++)
            {
                edgesProbability[i] /= sum;
            }

            return edgesProbability;
        }

        private Edge getLastEdge()
        {
            Edge[] edges = graph.edgesFrom(currentPoint);
            Edge lastEdge = null;
            for (int i = 0; i < edges.Length; i++)
            {
                if (edges[i].getAnotherPoint(currentPoint).Equals(startPoint))
                {
                    lastEdge = edges[i];
                    break;
                }
            }
            return lastEdge;
        }

        private void increaseDeltaAfterCycle()
        {
            if (type.Equals("cycle"))
            {
                double delta = q3 / cycleLength;
                for (int i = 0; i < visitedEdges.Count; i++)
                {
                    visitedEdges[i].increaseDelta(delta);
                }
            }

        }

        private void updatePheromoneAfterStep()
        {
            Edge last = visitedEdges.Last();
            switch (type)
            {
                case "density":
                    last.increaseDelta(q1);
                    last.updatePheromone();
                    break;
                case "quantity":
                    last.increaseDelta(q2 / last.distance);
                    last.updatePheromone();
                    break;
            }
        }



        public void reset()
        {
            currentPoint = startPoint;
            tabu = new Point[graph.amountOfPoints];
            tabu[0] = startPoint;
            position = 0;
            visitedEdges.Clear();
            cycleLength = 0;
        }

    }
}
