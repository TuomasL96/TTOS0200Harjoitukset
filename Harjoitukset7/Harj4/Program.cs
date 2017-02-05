using System;

namespace Harj4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestShapes();
        }
        static void TestShapes()
        {
            Shapes shapes = new Shapes();

            shapes.Add(new Circle(1));
            shapes.Add(new Circle(2));
            shapes.Add(new Circle(3));

            shapes.Add(new Rectangle(10, 20));
            shapes.Add(new Rectangle(20, 30));
            shapes.Add(new Rectangle(40, 50));

            foreach (Shape item in shapes.list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
