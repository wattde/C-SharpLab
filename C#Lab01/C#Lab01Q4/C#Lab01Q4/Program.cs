using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab01Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the employee's salary: ");
            double salary = double.Parse(Console.ReadLine());

           
            Console.Write("Enter the tax rate (in decimal, e.g., 0.2 for 20%): ");
            double taxRate = double.Parse(Console.ReadLine());

            
            double salaryAfterTax = salary * (1 - taxRate);

            
            Console.WriteLine($"Employee's salary after tax: {salaryAfterTax:C}");
            Console.ReadKey();
        }
    }
}
