using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab03Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

           
            for (; number != 0; number /= 10)
            {
                int digit = number % 10;
                sum += digit;
            }

            Console.WriteLine("The sum of the digits is: " + sum);
            Console.ReadKey();
        }
    }
}
