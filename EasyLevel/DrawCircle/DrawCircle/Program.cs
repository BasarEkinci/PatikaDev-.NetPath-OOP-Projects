using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of circle: ");
            int radius = int.Parse(Console.ReadLine());

            Circle.DrawCircle(radius);
            Console.ReadLine();
        }
    }
}
