using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCircle
{
    internal class Circle
    {
        public static void DrawCircle(int radius)
        {
            double angle, x, y;

            for (y = radius; y >= -radius; --y)
            {
                for (x = -radius; x <= radius; x += 0.5)
                {
                    if (radius - 0.5 < Math.Sqrt(x * x + y * y) && Math.Sqrt(x * x + y * y) < radius + 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
