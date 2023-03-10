using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Enter a string: ");

                foreach (var item in Console.ReadLine().Split())
                {
                    bool output = false;
                    for (int i = 1; i < item.Length; i++)
                    {
                        if (isConsonant(item[i]) == isConsonant(item[i - 1]))
                            output = true;
                    }
                    Console.Write(output + " ");
                }
                Console.WriteLine(" ");
                bool isConsonant(char c)
                {
                    return !"aeıioöuüAEIİOÖUÜ".ToCharArray().Contains(c);
                }
            }
        }


    }
}
