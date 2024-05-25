using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6maximumOccurringChar
{
    internal class Program
    {
        // Write a program in C# Sharp to find maximum occurring character in a string.
        static void Main(string[] args)
        {
            // Take user input for the string
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();

            // Call the function to find the maximum occurring character
            char maxChar = FindMaxOccurringChar(inputString, out int maxCount);

            // Display the result
            Console.WriteLine($"The highest frequency of the character '{maxChar}' appears {maxCount} time(s).");

            Console.ReadKey();
        }
        static char FindMaxOccurringChar(string str, out int maxCount)
        {
            int[] charCounts = new int[256]; // Array to store the count of each character (ASCII assumption)

            // Iterate over each character in the string
            foreach (char c in str)
            {
                // Increment the count of the character in the array
                if (c != ' ') // Ignoring spaces
                {
                    charCounts[c]++;
                }
            }

            // Initialize variables to store the maximum count and character
            char maxChar = ' ';
            maxCount = 0;

            // Find the character with the maximum count
            for (int i = 0; i < charCounts.Length; i++)
            {
                if (charCounts[i] > maxCount)
                {
                    maxChar = (char)i;
                    maxCount = charCounts[i];
                }
            }
            return maxChar;
        }
    }
}
