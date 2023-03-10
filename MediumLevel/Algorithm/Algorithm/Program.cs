using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many numbers do you want to enter: ");
            Console.Write("===> ");
            int lenght = int.Parse(Console.ReadLine());

            int[] numbers = new int[lenght];

            for(int i = 0;i< numbers.Length;i++)
            {
                Console.Write("-> ");
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            int sum = 0;
            int absSum = 0;
            for(int i = 0;i< numbers.Length;i++)
            {
                if (numbers[i] < 67) 
                {
                    int extraction = 67 - numbers[i];
                    sum += extraction;
                }
                else
                {
                    int extraction = Math.Abs(67 - numbers[i]);
                    absSum += (extraction * extraction);              
                }
            }

            Console.Write(" " + sum + " ");
            Console.Write(" " + absSum + " ");

            Console.ReadLine();
        }

    }
}
