using Kurs3Inlamningsuppgift3TDD;
using System;

namespace Kurs3Inlamningsuppgift3TDD
{
    public class GeometricCalculator // Denna är inte abstrakt för den ska instantieras i unit test.
    {
        public float GetArea(GeometricThing figure)
        {
            return 0;
        }

        public float GetPerimeter(GeometricThing figure)
        {
            return 0;
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
        public float Radius { get; set; }
        public float Diameter { get; set; }
        public float GetCircleArea()
        {
            return Pi * (Radius * Radius);
        }
        public float GetCirclePerimeter()
        {
            return Pi * (Radius * 2);
        }
    }

    #region Fyrkanter (rektangler och kvadrater)
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
        // Samman beräkning som rektangel, så ingen extra beräkning behövs här.
        public float Basen { get; set; }
        public float Height { get; set; }
    }
    #endregion

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
        // samma som vanlig triangel, så ingen extra beräkning behövs här.
    }

    internal class LikbentTriangel : Triangle
    {
        // samma som vanlig triangel, så ingen extra beräkning behövs här.
    }

    internal class LiksidigTriangel : Triangle
    {
        // samma som vanlig triangel, så ingen extra beräkning behövs här.
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