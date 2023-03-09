using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of the Triangle: ");
            int height = int.Parse(Console.ReadLine());

            Triangle.DrawTriangle(height);
            Console.ReadLine();
        }
    }
}
