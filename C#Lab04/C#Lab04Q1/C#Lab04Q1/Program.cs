using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab04Q1
{
    
    
        class ConvertValues
        {
            public void kilometerToMeter()
            {
                Console.Write("Enter the value in Kilometers (km): ");
                double kilometers = double.Parse(Console.ReadLine());

                double meters = kilometers * 1000;

                Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ConvertValues converter = new ConvertValues();
                converter.kilometerToMeter();

                
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }

