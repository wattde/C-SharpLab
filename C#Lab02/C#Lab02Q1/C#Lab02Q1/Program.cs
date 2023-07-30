using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab02Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;
            Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
