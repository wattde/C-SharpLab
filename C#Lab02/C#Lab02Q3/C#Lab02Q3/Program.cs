using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab02Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine($"Area of the circle: {area:F2}");
            Console.WriteLine($"Circumference of the circle: {circumference:F2}");

            Console.ReadLine();
        }
    }
}
