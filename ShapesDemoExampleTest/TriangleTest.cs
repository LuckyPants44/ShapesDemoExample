using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesDemoExample.Objects;
using System;
using System.Drawing;
using System.Linq;

namespace ShapesDemoExampleTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetShapeArea_OneTwoOne_ReturnZero()
        {
            Assert.AreEqual(0, Triangle.GetShapeArea(1, 2, 1));
        }

        [TestMethod]
        public void GetShapeArea_FiveTwoFive_ReturnFourEightyEight()
        {
            var result = Triangle.GetShapeArea(5, 2, 5);

            Assert.AreEqual(4.8990, Math.Round(result, 4));
        }

        [TestMethod]
        public void GetShapePerimeter_OneTwoFivePointOne_ReturnZero()
        {
            Assert.AreEqual(0, Triangle.GetPerimeter(1, 2, 5.1));
        }

        [TestMethod]
        public void GetShapePerimeter_ThreeTwoPointFivePointOne_ReturnTenPointSix()
        {
            Assert.AreEqual(10.6, Triangle.GetPerimeter(3, 2.5, 5.1));
        }

        [TestMethod]
        public void IsTriangleExist_FiveFiveTwelve_ReturnFalse()
        {
            Assert.IsTrue(!Triangle.IsTriangleExist(5, 5, 12));
        }

        [TestMethod]
        public void IsTriangleExist_ThreeTwoFour_ReturnTrue()
        {
            Assert.IsTrue(Triangle.IsTriangleExist(3, 2, 4));
        }

        [TestMethod]
        public void IsRightTriangle_OneTwoTwoPointTwoThreeSix_ReturnTrue()
        {
            Assert.IsTrue(Triangle.IsRightTriangle(1, 2, 2.236));
        }

        [TestMethod]
        public void IsRightTriangle_OneTwoTwo_ReturnFalse()
        {
            Assert.IsTrue(!Triangle.IsRightTriangle(1, 2, 2));
        }

        [TestMethod]
        public void GetSides_ZeroZeroOneOneZeroOne_ReturnOneOneOnePointFourtyOne()
        {
            var sides = Triangle.GetSides(new Point(0, 0), new Point(1, 1), new Point(0, 1));

            Assert.IsTrue(sides.All(x => x == 1 || Math.Round(x, 2) == 1.41));
        }

        [TestMethod]
        public void GetSides_ZeroZeroOneTwoZeroMinusThree_ReturnTwoPointTwentyFourThreeFivePointOne()
        {
            var sides = Triangle.GetSides(new Point(0, 0), new Point(1, 2), new Point(0, -3));

            Assert.IsTrue(sides.All(x => Math.Round(x, 2) == 2.24 || x == 3 || Math.Round(x, 2) == 5.1));
        }
    }
}