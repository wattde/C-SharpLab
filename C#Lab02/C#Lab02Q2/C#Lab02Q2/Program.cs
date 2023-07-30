using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab02Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

           
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            
            Console.WriteLine($"Sum: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine($"Division: {(num2 != 0 ? (num1 / num2).ToString() : "Cannot divide by zero")}");
            Console.ReadKey();
        }
    }
}
