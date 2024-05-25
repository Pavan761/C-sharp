using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddoreven
{
    internal class Program
    {
        //Write a program to check whether it is odd or even
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number to check if it's odd or even: ");
            // Read and parse the number from the user input
            int number = int.Parse(Console.ReadLine());

            // Check if the number is even
            if (number % 2 == 0)
            {
                // If the remainder when divided by 2 is 0, it is even
                Console.WriteLine("Output - even");
            }
            else
            {
                // If the remainder when divided by 2 is not 0, it is odd
                Console.WriteLine("Output - odd");
            }
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
