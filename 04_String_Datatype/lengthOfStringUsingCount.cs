using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lengthOfStringUsingCount
{
    internal class Program
    {
        // Write a Program to calculate the length of the string using count function  
        static void Main(string[] args)
        {
            // Given string
            // Prompt user to enter a string
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Calculate the length of the string manually
            int length = 0;
            foreach (char c in input)
            {
                length++;
            }

            // Print the length of the string
            Console.WriteLine("The Length of the String is: " + length);

            Console.ReadKey();
        }
    }
}
