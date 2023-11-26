using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CalculateSquareTest_radius2()
        {
            //arrange
            double radius = 2;
            double expected = 12.56;

            //act
            Circle circle = new Circle(radius);

            double actual = circle.CalculateSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateSquareTest_radius15()
        {
            //arrange
            double radius = 15;
            double expected = 706.5;

            //act
            Circle circle = new Circle(radius);

            double actual = circle.CalculateSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}