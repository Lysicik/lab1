using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Figure
    {
        public abstract string FigureName { get; }

        public override string ToString()
        {
            return $"{this.FigureName} с площадью {this.Area()}";
        }
        public abstract double Area();
    }
}
