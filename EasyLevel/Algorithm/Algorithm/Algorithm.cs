using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Algorithm
    {
        public static void RemoveLetter()
        {
            Console.Write("Please enter a string and index value: ");
            string input = Console.ReadLine();


            string[] parts = input.Split(',');
            string str = parts[0].Trim();
            int index = int.Parse(parts[1].Trim());

            if (index < 0 || index >= str.Length)
            {
                Console.WriteLine("Error: Invalid index value");
                return;
            }
            string output = str.Remove(index, 1);
            Console.WriteLine(output);
        }
    }
}
