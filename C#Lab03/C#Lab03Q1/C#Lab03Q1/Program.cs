using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab03Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            string result = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);
            Console.ReadLine();
        }

       
    }
}
