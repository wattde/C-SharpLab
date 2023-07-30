using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab04Q5
{
  
 
      
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the radius of the circle:");
                double radius = double.Parse(Console.ReadLine());

                FindValues circleCalculator = new FindValues();
                double area = circleCalculator.FindArea(radius);
                double circumference = circleCalculator.FindCircumference(radius);

                Console.WriteLine($"Area of the circle: {area}");
                Console.WriteLine($"Circumference of the circle: {circumference}");
                Console.ReadKey();
            }
        }

        class FindValues
        {
            public double FindArea(double radius)
            {
                double area = Math.PI * radius * radius;
                return area;
            }

            public double FindCircumference(double radius)
            {
                double circumference = 2 * Math.PI * radius;
                return circumference;
            }
        }
    }
    

