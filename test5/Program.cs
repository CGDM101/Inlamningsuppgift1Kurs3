using System;

namespace Kurs3Inlamningsuppgift3TDD
{
    public class GeometricCalculator // Denna är inte abstrakt för den ska instantieras i unit test?
    {
        public float GetArea(GeometricThing figure) 
        {
            return figure.Area;
        }

        public float GetPerimeter(GeometricThing figure) 
        {
            return figure.Perimeter;
        }

        public float GetPerimeter(GeometricThing[] figure)
        {
            return 0; 
        }
    }

    public abstract class GeometricThing : GeometricCalculator
    {
        public float Area { get; set; }
        public float Perimeter { get; set; }
    }

    public class Circle : GeometricThing
    {
        public float Pi { get; set; } = (float)Math.PI;
        public float Radius { get; set; } = 2;
        public float Diameter { get; set; } = 4; // Dubbelt så stort som radien.
        public float GetCircleArea() // TODO:
        {

        }
        public float GetCirclePerimeter() // TODO:
        {

        }
    }

    public class Rectangle : GeometricThing
    {
        public float Basen { get; set; }
        public float Height { get; set; }
        public float GetRectangleArea()
        {
            return Basen * Height;
        }
        public float GetRectanglePerimeter()
        {
            return (Basen * 2) + (Height * 2);
        }
    }

    public class Kvadrat : GeometricThing
    {
        public float Basen { get; set; }
        public float Height { get; set; }
    }

    #region Trianglar
    public class Triangle : GeometricThing
    {
        public float Basen { get; set; }
        public float Höjden { get; set; }
        public float Sida1 { get; set; }
        public float Sida2 { get; set; }
        public float Sida3 { get; set; }

        public float GetTriangleArea()
        {
            return (Basen * Höjden) / 2;
        }
        public float GetTrianglePerimeter()
        {
            return Sida1 + Sida2 + Sida3;
        }
    }

    internal class RatvinkligTriangel : Triangle
    {

    }

    internal class LikbentTriangel : Triangle
    {

    }

    internal class LiksidigTriangel : Triangle
    {
 
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
