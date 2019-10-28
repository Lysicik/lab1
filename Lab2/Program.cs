using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle(1);
            Rectangle b = new Rectangle(4, 7);
            Square c = new Square(7);
            a.Print();
            b.Print();
            c.Print();

            Console.ReadKey();
        }
    }
}
