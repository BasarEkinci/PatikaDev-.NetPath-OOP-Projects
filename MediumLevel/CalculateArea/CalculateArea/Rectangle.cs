using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void CalculatePerimeter()
        {
            double perimeter = (X + Y) * 2;
            Console.WriteLine("Perimeter of the Rectangle: " + perimeter);
        }
        public void CalculateArea()
        {
            double area = X * Y;
            Console.WriteLine("Area of The Rectangle: " + area);
        }
    }
}
