using System;

namespace ConsoleApp3
{
    public class Rectangle : Figure, IPrint
    {
        public Rectangle(double height = 0, double width = 0)
        {
            Height = height;
            Width = width;
        }
        public double Height { get; set; }
        public double Width { get; set; }

        public override string FigureName => "Прямоугольник";

        public override double Area()
        {
            return Width * Height;
        }

        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString()
        {
            return $"{FigureName}, S = {Area()}, A = {Height}, B = {Width}";
        }
    }
}
