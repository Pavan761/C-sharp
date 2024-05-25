using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6voweldigitsymbol
{
    //Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a character
            Console.Write("Enter the char: ");
            // Read a single character from the user input
            char outlet = ReadSingleCharacter();

            if (IsLowerVowel(outlet))
            {
                Console.WriteLine("It is Lower vowel.");
            }
            else if (Isnumber(outlet))
            {
                Console.WriteLine("It is digit.");
            }
            else
            {
                Console.WriteLine("It is other symbol.");
            }

            Console.ReadKey();
        }
        // Method to check if a character is a lowercase vowel
        static bool IsLowerVowel(char ch)
        {
            return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
        }

        // Method to check if a character is a digit
        static bool Isnumber(char ch)
        {
            return ch >= '0' && ch <= '9';
        }

        // Method to read a single character from the user input
        static char ReadSingleCharacter()
        {
            string z = Console.ReadLine();

            // Ensure that the input string contains exactly one character
            if (z.Length != 1)
            {
                throw new ArgumentException("Give crrt letter");
            }
            // Return the first and only character of the input string
            return z[0];
        }
    }
}
