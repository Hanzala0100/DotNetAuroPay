using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Circle : IPolygon,Icolor
    {
        public void CalculateArea()
        {
            Console.WriteLine("Area is PI * r * r");
        }

        public void DisplaySides()
        {
            Console.WriteLine("it has no sides");
        }

        public void SetColor(string color)
        {
            Console.WriteLine($"Circle is of color: {color}");
        }
    }
}
