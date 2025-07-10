using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }

        public Rectangle(int length, int width)
        {
            if(length > 0)
                Length = length;
            else Length = 1;

            if (width > 0)
                Width = width;
            else Width = 1;
        }

        public double GetArea()
        {
            return Length*Width;
        }

        public bool IsSquare()
        {
            return Length==Width;
        }
    }
}
