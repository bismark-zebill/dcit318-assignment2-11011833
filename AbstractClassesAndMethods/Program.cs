// See https://aka.ms/new-console-template for more information
using System;
using System.Dynamic;

namespace AbstractClassesAndMethods
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(10);
            Shape rectangle = new Rectangle(10, 20);

            Console.WriteLine($"Area of circle is: {circle.GetArea():F2}");
            Console.WriteLine($"Area of rectangle is: {rectangle.GetArea():F2}");

            Console.ReadKey();
        }
    }
}
