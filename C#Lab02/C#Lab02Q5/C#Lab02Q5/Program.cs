using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab02Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numberOfInputs = 10;

            Console.WriteLine($"Enter {numberOfInputs} numbers:");

            for (int i = 0; i < numberOfInputs; i++)
            {
                Console.Write($"Input {i + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("The number is even.");
                    }
                    else
                    {
                        Console.WriteLine("The number is odd.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; 
                }
            }

            Console.ReadLine();
        }
    }
}
