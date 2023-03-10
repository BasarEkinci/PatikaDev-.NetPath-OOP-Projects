using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to enter (Must be a even number!) ?");
            Console.Write("====> ");
            int sayi = int.Parse(Console.ReadLine());
            if(sayi % 2 == 0) 
            {
                int[] numberArray = new int[sayi];

                for (int i = 0; i < numberArray.Length; i++)
                {
                    Console.Write((i + 1) + "th number: ");
                    int number = int.Parse(Console.ReadLine());
                    numberArray[i] = number;
                }

                for (int i = 0; i < numberArray.Length; i+=2)
                {
                    if (numberArray[i] == numberArray[i + 1])
                    {
                        int sum = numberArray[i] + numberArray[i + 1];
                        Console.Write(" " + (sum * sum) + " ");
                    }
                    else
                    {
                        int sum = numberArray[i] + numberArray[i + 1];
                        Console.Write(" " + sum + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input.Please enter even number!");
            }
           Console.ReadLine();
        }
              
    }

}
