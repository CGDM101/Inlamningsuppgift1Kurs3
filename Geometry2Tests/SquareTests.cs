using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry2.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void SquareTestArea()
        {
            Square myTestSquare = new Square(10);
            
            var expected = myTestSquare.Area();
            
            Assert.AreEqual(expected, 100); // 10 * 10
        }

        [TestMethod()]
        public void RectangleTestArea()
        {
            Rectangle myTestRectangle = new Rectangle(50);
            myTestRectangle.Width = 20;

            float expected = myTestRectangle.Area();
            
            Assert.AreEqual(expected, 1000); // 20 * 50
        }

        [TestMethod()]
        public void CircleTestArea() 
        {
            Circle myTestCircle = new Circle(10); // diametern

            double sut = Math.Round(myTestCircle.Area(), 1);

            Assert.AreEqual(sut, 31.4);
        }

        [TestMethod()]
        public void SquareTestPerimeter()
        {
            Square myTestSquare = new Square(10);
            myTestSquare.Height = 10; // samma som width

            float sut = myTestSquare.Perimeter();
            
            Assert.AreEqual(sut, 40); // 10 * 4 = 40
        }

        [TestMethod()]
        public void RectangleTestPerimeter()
        {
            Rectangle myTestRectangle = new Rectangle(50);
            myTestRectangle.Width = 20;

            float sut = myTestRectangle.Perimeter();

            Assert.AreEqual(sut, 140); // 50 * 2 + 20 * 2 = 140
        }

        [TestMethod()]
        public void CircleTestPerimeter()
        {
            Circle myTestCircle = new Circle(10); // diametern

            double sut = Math.Round(myTestCircle.Perimeter(), 1);

            Assert.AreEqual(sut, 78.5);
        }
    }
}