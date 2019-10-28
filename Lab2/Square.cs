using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Square : Figure, IPrint
    {
        public Square(double side = 0)
        {
            Side = side;
        }
        public double Side { get; set; }

        public override string FigureName => "Квадрат";

        public override double Area()
        {
            return Side*Side;
        }

        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString()
        {
            return $"{this.FigureName} с площадью {this.Area()} и стороной {Side}";
        }
    }
}
