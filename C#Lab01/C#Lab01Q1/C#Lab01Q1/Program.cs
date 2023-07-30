using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab01Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your batch:");
            string batch = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Batch: " + batch);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
