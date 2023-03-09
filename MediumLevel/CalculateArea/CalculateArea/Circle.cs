using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Circle
    {
        public int Radius { get; set; }
        

        public void CalculatePerimeter()
        {
            double perimeter = 2 *Math.PI * Radius;
            Console.WriteLine("Perimeter of the radius: " + perimeter);
        }
        public void CalculateArea()
        {
            double area = Math.Pow(Radius,2) * Math.PI;
            Console.WriteLine("Area of The Circle: " + area);
        }
    }
}
