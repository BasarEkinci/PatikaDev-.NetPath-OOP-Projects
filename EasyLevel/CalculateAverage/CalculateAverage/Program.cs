using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the depth of Fibonacci Series: ");
            int depth = int.Parse(Console.ReadLine());

            Fibonacci.Calculate(depth);

            Console.ReadLine();
        }
    }
}
