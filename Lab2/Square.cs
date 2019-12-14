using System;

namespace ConsoleApp3
{
    public class Square : Figure, IPrint
    {
        public Square(double side = 0)
        {
            Side = side;
        }
        public double Side { get; set; }

        public override string FigureName => "Квадрат";

        public override double Area()
        {
            return Side * Side;
        }

        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString()
        {
            return $"{this.FigureName}, S = {this.Area()}, A = {Side}";
        } 
    }
}
