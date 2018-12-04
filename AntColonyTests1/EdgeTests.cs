using System;
using System.Drawing;
using Xunit;
using AntColonyTSP;

namespace AntColonyTests1
{
    public class EdgeTests
    {
        [Theory]
        [InlineData(50, 0.5, 25)]
        [InlineData(50, 1, 50)]
        [InlineData(50, 0, 0)]
        [InlineData(80, 0.1, 8)]
        public void updatePheromone_PheromoneEvaporateTest(double initPher, double remainingPherPerc, double remained)
        {
            //Arrange
            Point a = new Point(0, 0);
            Point b = new Point(5, 5);
            edge = new Edge(a, b, initPher, remainingPherPerc);

            //Act
            edge.updatePheromone();

            //Assert
            Assert.Equal(remained, edge.pheromone);
        }

        #region CONFIGURATION
        Edge edge;
        #endregion


    }
}
