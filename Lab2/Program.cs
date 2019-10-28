using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle(5);
            Rectangle b = new Rectangle(3, 5);
            Square c = new Square(5);
            a.Print();
            b.Print();
            c.Print();

            Console.ReadKey();
        }
    }
}
