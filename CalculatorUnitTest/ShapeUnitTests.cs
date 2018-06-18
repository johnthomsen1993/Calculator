using System;
using CalculatorWPF.Model.Shapes._2DShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class ShapeUnitTests
    {
        [TestMethod]
        public void AreaOfSquare()
        {
            var Square = new Square(20,20);
            Assert.AreEqual(20*20, Square.Area());
        }
        [TestMethod]
        public void SquarePerimeter()
        {
            int a = 20;
            int b = 20;
            var Square = new Square(a, b);
            Assert.AreEqual(a+a+b+b, Square.Perimeter());
        }

        [TestMethod]
        public void AreaOfCircle()
        {
            var Circle = new Circle(20);
            Assert.AreEqual(20*20*Math.PI, Circle.Area());
        }
        [TestMethod]
        public void CirclePerimeter()
        {
            var Circle = new Circle(20);
            Assert.AreEqual(20 * 2 * Math.PI, Circle.Perimeter());
        }
        [TestMethod]
        public void AreaOfEllipse()
        {
            var Ellipse = new Ellipse(20,16);
            Assert.AreEqual(20*16*Math.PI, Ellipse.Area());
        }
        [TestMethod]
        public void EllipsePerimeter()
        {
            var RadiusA = 20;
            var RadiusB = 16;
            var Ellipse = new Ellipse(RadiusA, RadiusB);
            var h = Math.Pow((RadiusA - RadiusB), 2) / Math.Pow((RadiusA + RadiusB), 2);
            Assert.AreEqual(Math.PI * (RadiusA + RadiusB) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))), Ellipse.Perimeter());
        }

    }
}
