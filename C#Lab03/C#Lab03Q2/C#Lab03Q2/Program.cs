using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab03Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string input = Console.ReadLine();
            int vowelCount = CountVowels(input);
            Console.WriteLine($"Number of vowels: {vowelCount}");
        }

        static int CountVowels(string str)
        {
            int count = 0;
            foreach (char c in str.ToLower()) 
            {
                if (IsVowel(c)) 
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsVowel(char c)
        {
            
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
            Console.ReadKey();
        }
    }
}
            
            
     

