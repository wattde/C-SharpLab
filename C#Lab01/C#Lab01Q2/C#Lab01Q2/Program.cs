using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab01Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Circle Area Calculator");
                Console.WriteLine("");

                
                Console.Write("Enter the radius of the circle: ");
                string radiusInput = Console.ReadLine();

                
                if (double.TryParse(radiusInput, out double radius))
                {
                    
                    if (radius >= 0)
                    {
               
                        double area = Math.PI * radius * radius;

                        
                        Console.WriteLine($"The area of the circle with radius {radius} is: {area:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: The radius cannot be negative.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid number for the radius.");
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
    

