using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab04Q2
{
    class ConvertValues
    {
        public void KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value in Kilometers (km): ");
            double kilometers = double.Parse(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            converter.KilometerToMeter(kilometers);

          
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

