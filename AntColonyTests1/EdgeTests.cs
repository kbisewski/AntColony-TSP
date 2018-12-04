using System;
using System.Drawing;
using Xunit;
using AntColony;

namespace AntColonyTests1
{
    public class EdgeTests
    {
        [Fact]
        public void PheromoneEvaporateTest()
        {
            //Arrange
            Point a = new Point(0, 0);
            Point b = new Point(5, 5);
            edgeTests = new Edge(a, b, 50, 0.5);

            //Act
            edgeTests.updatePheromone();

            //Assert
            Assert.Equal(25, edgeTests.pheromone);
        }

        #region CONFIGURATION
        Edge edgeTests;
        #endregion


    }
}
