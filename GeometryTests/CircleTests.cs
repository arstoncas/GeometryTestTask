using Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void NegativeRadius()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-2.0));
        }

        [TestMethod]
        public void RadiusIsZero()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0.0));
        }

        [TestMethod]
        public void AreaCalc()
        {
            var radius = 10;
            Circle crc = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2d);
            Assert.AreEqual(expectedValue, crc.GetArea());
        }
    }
}
