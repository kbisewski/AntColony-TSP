using System;
using System.Drawing;
using Xunit;
using AntColonyTSP;
using System.Collections.Generic;

namespace AntColonyTests1
{
    public class GraphTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void EdgesFrom_amountOfEdgesTest(int pointsAmount)
        {
            //Arrange
            List<Point> points = new List<Point>();
            Point p = new Point(0, 0);
            points.Add(p);
            for (int i = 1; i < pointsAmount; i++)
            {
                points.Add(new Point(i, i));
            }

            graph = new Graph(points, 50, 0.5);

            //Act
            int edgesFromP = graph.edgesFrom(p).Length;

            //Assert
            Assert.Equal(edgesFromP, pointsAmount - 1);
        }

        #region CONFIGURATION
        Graph graph;
        #endregion


    }
}
