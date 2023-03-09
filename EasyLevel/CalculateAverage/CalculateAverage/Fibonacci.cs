using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverage
{
    internal class Fibonacci
    {
        public static void Calculate(int depth)
        {
            int sum = 0;
            int count = 0;
            int n1 = 0;
            int n2 = 1;

            while (count < depth) 
            {
                sum = n1 + n2;
                n1 = n2;        
                n2 = sum;
                count++;
            }
            double average = (double)sum / depth;

            Console.WriteLine("Average of Numbers int the Fibonacci Series: {0}",average);
        }
    }
}
