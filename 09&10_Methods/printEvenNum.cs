using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Print_even_num
{
    // Write a program to print entered number of even numbers in c#.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of even numbers
            Console.Write("Enter the number of even numbers: ");
            // Read the count of even numbers from the console
            int count = int.Parse(Console.ReadLine());

            // Check if the count is less than or equal to zero
            if (count <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return;
            }
            Console.WriteLine("Even numbers:");

            // Initialize the first even number
            int number = 2;
            for (int i = 0; i < count; i++)
            {
                Console.Write(number + " ");
                number += 2;
            }
            Console.WriteLine();
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
