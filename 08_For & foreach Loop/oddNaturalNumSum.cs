using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Odd_natural_num_sum
{
    // 2. Write a program in C# Sharp to display the n terms of odd natural number and their sum.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input the number of terms
            Console.Write("Input number of terms: ");
            int n = int.Parse(Console.ReadLine());


            // Initialize variables for sum and the current odd number
            int sum = 0;
            int currentOddNumber = 1;

            // Display the odd numbers
            Console.WriteLine("The odd numbers are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(currentOddNumber + " ");
                sum = sum + currentOddNumber;
                currentOddNumber = currentOddNumber + 2;
            }
            // Display the sum of odd natural numbers up to n terms
            Console.WriteLine("\nThe Sum of odd Natural Number upto {0} terms: {1}", n, sum);
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
