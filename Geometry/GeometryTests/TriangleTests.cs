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
    public class TriangleTests
    {
        [TestMethod()]
        public void СheckForRightTest3_4_5()
        {
            //arrange
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            bool expected = true;

            //act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            bool actual = triangle.СheckForRight();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void СheckForRightTest10_7_5()
        {
            //arrange
            double firstSide = 10;
            double secondSide = 7;
            double thirdSide = 5;
            bool expected = false;

            //act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            bool actual = triangle.СheckForRight();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateSquareTest3_4_5()
        {
            //arrange
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            double expected = 6;

            //act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            double actual = triangle.CalculateSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateSquareTest10_7_5()
        {
            //arrange
            double firstSide = 10;
            double secondSide = 7;
            double thirdSide = 5;
            double expected = 16.24807680927192;

            //act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            double actual = triangle.CalculateSquare();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}