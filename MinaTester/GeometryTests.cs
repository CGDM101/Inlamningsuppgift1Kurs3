using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurs3Inlamningsuppgift3TDD; // Projektet som ska testas.
using System;

namespace MinaTester
{
    [TestClass]
    public class GeometryTests
    {
        #region RectangleTests
        [TestMethod]
        public void TestRectangleArea()
        {
            GeometricCalculator calc = new GeometricCalculator();
            Rectangle rect = new Rectangle();
            rect.Basen = 10;
            rect.Height = 5;

            var result = calc.GetArea(rect);

            Assert.AreEqual(result, 50); // 10 * 5
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            GeometricCalculator calc = new GeometricCalculator();
            Rectangle rect = new Rectangle();
            rect.Basen = 10;
            rect.Height = 5;

            var result = calc.GetPerimeter(rect);

            Assert.AreEqual(result, 30); // 10 + 10 + 5 + 5
        }

        [TestMethod]
        public void TestPerimeterOfManyRectangles()
        {
            GeometricCalculator calc = new GeometricCalculator();
            Rectangle rectangle = new Rectangle();
            Rectangle rectangle2 = new Rectangle();
            rectangle.Basen = 10;
            rectangle.Height = 5;
            rectangle2.Basen = 11;
            rectangle2.Height = 6;

            var result = calc.GetPerimeter(rectangle, rectangle2);

            Assert.AreEqual(result, 30); // 10 + 10 + 5 + 5 + 11 + 11 + 6 + 6 = 64
        }
        #endregion

        #region TriangleTests
        [TestMethod]
        public void TestTrianglePerimeter()
        {
            GeometricCalculator calc = new GeometricCalculator();
            Triangle triangle = new Triangle();
            triangle.Basen = 10;
            triangle.Höjden = 5;
            triangle.Sida1 = 10;
            triangle.Sida2 = 10;
            triangle.Sida3 = 10;

            var result = calc.GetPerimeter(triangle);

            Assert.AreEqual(result, 30); // 10 + 10 + 10
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            GeometricCalculator calc = new GeometricCalculator();
            Triangle triangle = new Triangle();
            triangle.Basen = 10;
            triangle.Höjden = 5;

            var result = calc.GetArea(triangle);

            Assert.AreEqual(result, 25); // (10 * 5) / 2
        }

        [TestMethod]
        public void TestPerimeterfManyTriangles()
        {
            GeometricCalculator calc = new GeometricCalculator();
            Triangle triangle = new Triangle();
            Triangle triangle2 = new Triangle();
            triangle.Sida1 = 10;
            triangle.Sida2 = 5;
            triangle.Sida3 = 3;
            triangle2.Sida1 = 11;
            triangle2.Sida2 = 6;
            triangle2.Sida3 = 4;

            var result = calc.GetPerimeter(triangle, triangle2);

            Assert.AreEqual(result, 39);
        }
        #endregion TriangleTests

        #region CircleTests

        [TestMethod]
        public void TestCircleArea()
        {
            GeometricCalculator calc = new GeometricCalculator();
            Circle circle = new Circle();
            circle.Radius = 5;
            circle.Diameter = (circle.Radius * 2);
            circle.Pi = (float)Math.PI;

            var result = 0;
        }

        [TestMethod]
        public void TestCirclePerimeter()
        {
            GeometricCalculator calc = new GeometricCalculator();
            Circle circle = new Circle();
            circle.Radius = 5;
            circle.Diameter = (circle.Radius * 2);
            circle.Pi = (float)Math.PI;

            var result = 0;
        }

        [TestMethod]
        public void TestPerimeterOfManyCircles()
        {
            GeometricCalculator calc = new GeometricCalculator();
            Circle circle = new Circle();
            circle.Radius = 5;
            circle.Diameter = (circle.Radius * 2);
            circle.Pi = (float)Math.PI;
            Circle circle2 = new Circle();
            circle2.Radius = 5;
            circle2.Diameter = (circle.Radius * 2);
            circle2.Pi = (float)Math.PI;

            var result = calc.GetPerimeter(circle, circle2);
        }
        #endregion
    }
}
