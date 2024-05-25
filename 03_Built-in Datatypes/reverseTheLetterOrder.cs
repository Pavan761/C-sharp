using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5reverseorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the first letter
            Console.Write("Enter the 1st letter: ");
            // Read the first letter from the user input
            char first = ReadSingleCharacter();

            // Prompt the user to enter the second letter
            Console.Write("Enter the 2nd letter: ");
            // Read the second letter from the user input
            char second = ReadSingleCharacter();

            Console.Write("Enter the 3rd letter: ");
            char third = ReadSingleCharacter();

            // Output the letters in reverse order
            Console.WriteLine("Output: {0} {1} {2}", third, second, first);

            Console.ReadKey();
        }
        static char ReadSingleCharacter()
        {
            // Read the user input
            string input = Console.ReadLine();

            // Check if the input length is not equal to 1 (i.e., if it's not a single character)
            if (input.Length != 1)
            {
                // Throw an ArgumentException with a message
                throw new ArgumentException("Please enter a single character.");
            }
            // Return the first character of the input string
            return input[0];
        }
    }
}
