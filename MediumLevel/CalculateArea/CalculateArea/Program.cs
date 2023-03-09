using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int operation = 0;
            bool isContinue = true;
                while (isContinue) 
                {
                    Console.WriteLine("Please Choose a Shape: ");
                    Console.WriteLine("1.Circle");
                    Console.WriteLine("2.Triangle");
                    Console.WriteLine("3.Rectangle");
                    Console.WriteLine("4.Type 'Exit' to exit");
                    Console.Write("====> ");
                    string shape = Console.ReadLine();
                    shape.ToLower().Trim();
                    switch (shape)
                    {
                        case "circle":
                            Circle circle = new Circle();
                            Menu();
                            operation = int.Parse(Console.ReadLine());
                            if (operation == 1)
                            {
                                Console.Write("Enter a Radius Value: ");
                                circle.Radius = int.Parse(Console.ReadLine());
                                circle.CalculatePerimeter();
                            }
                            else if (operation == 2)
                            {
                                Console.WriteLine("Enter a Radius Value: ");
                                circle.Radius = int.Parse(Console.ReadLine());
                                circle.CalculateArea();
                            }
                            else if (operation == 3)
                            {
                                break;
                            }
                            break;
                        case "rectangle":
                            Rectangle rectangle = new Rectangle();
                            Menu();
                            operation = int.Parse(Console.ReadLine());
                            if (operation == 1)
                            {
                                Console.WriteLine("Enter Width and Lenght Values: ");

                                Console.Write("Width: ");
                                rectangle.X = int.Parse(Console.ReadLine());
                                Console.Write("Lenght: ");
                                rectangle.Y = int.Parse(Console.ReadLine());

                                rectangle.CalculatePerimeter();
                            }
                            else if (operation == 2)
                            {
                                Console.WriteLine("Enter Width and Lenght Values: ");

                                Console.Write("Width: ");
                                rectangle.X = int.Parse(Console.ReadLine());
                                Console.Write("Lenght: ");
                                rectangle.Y = int.Parse(Console.ReadLine());

                                rectangle.CalculateArea();
                            }
                            else if (operation == 3)
                            {
                                break;
                            }
                            break;
                        case "triangle":
                            Triangle triangle = new Triangle();
                            Menu();
                            operation = int.Parse(Console.ReadLine());
                            if (operation == 1)
                            {
                                Console.WriteLine("Enter the side lengths of the triangle: ");
                                Console.Write("X: ");
                                triangle.X = int.Parse(Console.ReadLine());
                                Console.Write("Y: ");
                                triangle.Y = int.Parse(Console.ReadLine());
                                Console.Write("Z: ");
                                triangle.Z = int.Parse(Console.ReadLine());

                                triangle.CalculatePerimeter();

                            }
                            else if (operation == 2)
                            {
                                Console.WriteLine("Enter the side lengths of the triangle: ");
                                Console.Write("X: ");
                                triangle.X = int.Parse(Console.ReadLine());
                                Console.Write("Y: ");
                                triangle.Y = int.Parse(Console.ReadLine());
                                Console.Write("Z: ");
                                triangle.Z = int.Parse(Console.ReadLine());

                                triangle.CalculateArea();
                            }
                            else if (operation == 3)
                            {
                                break;
                            }
                            break;
                        case "exit":
                        isContinue = false;
                            break;
                    }
                }   
            
        }

        static void Menu()
        {
            Console.WriteLine("Enter the Operation you want to do: ");
            Console.WriteLine("1.Calculate Perimeter");
            Console.WriteLine("2.Calculate Area");
            Console.WriteLine("3.Choose Another Shape");
            Console.Write("====> ");
        }
    }
}
