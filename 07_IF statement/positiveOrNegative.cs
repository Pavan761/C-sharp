using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Positive_or_negative
{
    // 1. Write a C# Sharp program to check whether a given number is positive or negative.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is positive, negative, or zero
            if (number > 0)
            {
                // Display if the number is positive
                Console.WriteLine(number + " is a positive number");
            }
            else if (number < 0)
            {
                Console.WriteLine(number + " is a negative number");
            }
            else
            {
                Console.WriteLine(number + " is zero");
            }
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
