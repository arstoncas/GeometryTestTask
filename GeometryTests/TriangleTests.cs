using Geometry;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void NegativeSide()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-2, 4, 7));
        }

        [TestMethod]
        public void SideIsZero()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(4, 0, 8));
        }

        [TestMethod]
        public void NotATriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 2, 5));
        }

        [TestMethod]
        public void AreaCalc()
        {
            double a = 3, b = 5, c = 7;
            double halfPerim = 7.5; 

            double result = Math.Sqrt(halfPerim * (halfPerim - a) * (halfPerim - b) * (halfPerim - c));
            
            var triangle = new Triangle(a, b, c);
            var square = triangle.GetArea();

            Assert.AreEqual(result, square);
        }

        [TestMethod]
        public void TriangleIsRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        public void TriangleIsNotRight()
        {
            Triangle triangle = new Triangle(5, 5, 8);
            Assert.IsFalse(triangle.IsRightAngled());
        }

    }
}
