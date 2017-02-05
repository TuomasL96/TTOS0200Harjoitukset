using System.Collections.Generic;

namespace Harj4
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public abstract double Area();
        public abstract double Circumference();
    }

    public class Shapes
    {
        public List<Shape> list = new List<Shape>();
        public void Add(Shape shape)
        {
            list.Add(shape);
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * (Radius * Radius);
        }

        public override double Circumference()
        {
            return 2 * 3.14 * Radius;
        }

        public override string ToString()
        {
            return "Circle Radius=" + Radius + " Area=" + Area() + " Circumference=" + Circumference();
        }
    }

    public class Rectangle : Shape
    {
        double Width { get; set; }
        double Height { get; set; }

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Height * Width;
        }

        public override double Circumference()
        {
            return 2 * (Height + Width);
        }

        public override string ToString()
        {
            return "Rectangle Width=" + Width + " Height=" + Height + " Area=" + Area() + " Circumference=" + Circumference();
        }
    }
}
