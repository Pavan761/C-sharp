using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lengthOfString
{
    internal class Program
    {
        // Write a program in C# Sharp to find the length of a string without using library function.
        static void Main(string[] args)
        {
            // Prompt the user to enter a string
            Console.Write("Enter a string: ");
            string a = Console.ReadLine();

            // Find the length of the string
            int length = FindStringLength(a);

            // Print the length of the string
            Console.WriteLine("Length of the string is: " + length);

            Console.ReadKey();
        }
        static int FindStringLength(string str)
        {
            // Initialize a variable to store the length of the string
            int length = 0;

            // Iterate through the characters of the string until the null character is encountered
            foreach (char c in str)
            {
                // Check if the current character is the null character
                if (c == '\0')
                {
                    // Break the loop if the null character is encountered
                    break;
                }

                // Increment the length for each character
                length++;
            }

            // Return the length of the string
            return length;
        }
    }
}
