using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Lab05Q1
{
    
    
        public static void ArrayOperations(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int sum = 0;

            // Calculate min, max, and sum
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];

                sum += arr[i];
            }

            double average = (double)sum / arr.Length;

            // Display results
            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
            Console.WriteLine("Average value: " + average);

            // Reverse the array
            Array.Reverse(arr);
            Console.WriteLine("Reverse order of values:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();