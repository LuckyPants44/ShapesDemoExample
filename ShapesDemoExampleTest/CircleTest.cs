using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesDemoExample.Objects;
using System;

namespace ShapesDemoExampleTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetArea_RadiusIsFive_ReturnSeventyEight()
        {
            var result = new Circle(5).GetShapeArea();

            Assert.AreEqual(78.5398, Math.Round(result, 4));
        }

        [TestMethod]
        public void GetArea_RadiusIsFourPointThree_ReturnFiftyEight()
        {
            var result = new Circle(4.3).GetShapeArea();

            Assert.AreEqual(58.088, Math.Round(result, 4));
        }

        [TestMethod]
        public void GetArea_RadiusIsTwoPointOne_ReturnThirteenPointEight()
        {
            var result = Circle.GetShapeArea(2.1);

            Assert.AreEqual(13.8544, Math.Round(result, 4));
        }

        [TestMethod]
        public void GetPerimeter_RadiusIsThreePointThree_ReturnTwentyPointSeven()
        {
            var result = new Circle(3.3).GetPerimeter();

            Assert.AreEqual(20.7345, Math.Round(result, 4));
        }

        [TestMethod]
        public void GetPerimeter_RadiusIsZeroPointThree_ReturnOnePointEightyEight()
        {
            var result = new Circle(0.3).GetPerimeter();

            Assert.AreEqual(1.885, Math.Round(result, 4));
        }

        [TestMethod]
        public void GetPerimeter_RadiusIsZeroPointFive_ReturnThreePointFourteen()
        {
            var result = Circle.GetPerimeter(0.5);

            Assert.AreEqual(3.1416, Math.Round(result, 4));
        }
    }
}