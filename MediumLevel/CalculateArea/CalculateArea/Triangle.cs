using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Triangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public void CalculateArea()
        {
            double perimeter = X + Y + Z;
            double s = perimeter / 2;
            double area = Math.Sqrt(s*((s-X)*(s-Y)*(s-Z)));
            Console.WriteLine("Area of the Triangle: " + area);
        }

        public void CalculatePerimeter()
        {
            double perimeter = X + Y + Z;
            Console.WriteLine("Perimeter of the Triangle: " + perimeter);
        }
    }
}
