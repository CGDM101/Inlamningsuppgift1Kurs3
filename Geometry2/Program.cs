using System;

namespace Geometry2
{
    abstract public class GeometricThing
    {
        public abstract float Height { set; }
        public abstract float Area();
        public abstract float Perimeter();
    } 

    public class Rectangle : GeometricThing
    {
        private float width;
        private float height;

        public Rectangle(float h)
        {
            this.height = h;
        }

        public override float Height { set => height = value; }
        public float Width { set => width = value; }
        public override float Area()
        {
            return this.height * this.width;
        }

        public override float Perimeter()
        {
            return (this.height * 2) + (this.width * 2);
        }
    }

    public class Square : GeometricThing
    {
        private float width = 0;
        private float height;

        public Square(float w)
        {
            this.width = w;
        }

        public override float Height { set => height = value; }
        public override float Area()
        {
            return this.width * this.width;
        }

        public override float Perimeter()
        {
            return this.height * 4;
        }
    }

    public class Circle : GeometricThing
    {
        private float height;

        public Circle(float h)
        {
            this.Height = h;
        }
        public override float Height { set => height = value; }
        public override float Perimeter() { return (float)Math.PI * ((height / 2) * (height / 2)); } // pi * (r * r)
        public override float Area(){ return (float)Math.PI * ((height / 2) * 2); } // pi * (r * 2)
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new Square(10); // w från konstruktorn
            Console.WriteLine($"Square area: {mySquare.Area()}");

            Rectangle myRectangle = new Rectangle(50); // h från konstruktorn
            myRectangle.Width = 20;
            Console.WriteLine($"Rectangle area: {myRectangle.Area()}");
        }
    }
}
