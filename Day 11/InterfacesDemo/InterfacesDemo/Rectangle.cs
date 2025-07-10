using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Rectangle : IPolygon, Icolor
    {
        public void CalculateArea()
        {
            Console.WriteLine("Area is Length * Breadth");
        }

        public void DisplaySides()
        {
            Console.WriteLine("4 sides");
        }

        public void SetColor(string color)
        {
            Console.WriteLine($"Reactange is of color: {color}");
        }
    }
}
