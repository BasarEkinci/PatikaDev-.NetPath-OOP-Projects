using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    internal class Triangle
    {
        public static void DrawTriangle(int size)
        {
            int row, space;
            for(row = 1; row <= size;row++)
            {
                //Add spaces
                for (space = 1; space <= (size - row); space++)
                {
                    Console.Write(" ");
                }
                //Add stars
                for(int i = 1; i <= (2 * row - 1); i++)
                {
                    Console.Write("*");
                }
                //Skip to next line
                Console.WriteLine();
            }
        }
    }
}
