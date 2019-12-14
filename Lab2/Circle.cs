using System;


namespace ConsoleApp3
{
    public class Circle : Figure, IPrint
    {
        public Circle(double radius = 0)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public override string FigureName => "Круг";

        public override double Area() => Math.PI * Radius * Radius;

        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString()
        {
            return $"{this.FigureName}, S = {this.Area()}, R = {Radius}";
        }

    }
}
