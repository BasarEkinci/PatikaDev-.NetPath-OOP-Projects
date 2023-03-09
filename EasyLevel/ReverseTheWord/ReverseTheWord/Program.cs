using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseTheWord("Hello World");
            Console.ReadLine();
        }
        public static void ReverseTheWord(string str)
        {
            string reverseString = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }

            Console.WriteLine("Entered Word: " + str);
            Console.WriteLine("Reversed Word: " + reverseString);
        }
    }
}
