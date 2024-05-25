using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseAString
{
    internal class Program
    {
        // Write a Program to Reverse a String without using Reverse function 
        static void Main(string[] args)
        {
            // Prompt the user to enter a string
            Console.Write("Enter a String: ");
            string z = Console.ReadLine();

            // Reverse the string
            string reversed = ReverseString(z);

            // Print the reversed string
            Console.WriteLine("Reverse String is: " + reversed);

            Console.ReadKey();
        }
        static string ReverseString(string input)
        {
            // Initialize an empty string to store the reversed string
            string reversed = "";

            // Iterate through the characters of the input string in reverse order
            for (int i = input.Length - 1; i >= 0; i--)
            {
                // Append each character to the reversed string
                reversed += input[i];
            }

            // Return the reversed string
            return reversed;
        }
    }
}
