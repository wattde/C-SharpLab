using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab01Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double summation = num1 + num2;
            Console.WriteLine($"The summation of {num1} and {num2} is: {summation}");
            Console.ReadKey();
        }
    }
}
