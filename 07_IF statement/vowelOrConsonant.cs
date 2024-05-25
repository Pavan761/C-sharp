using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Vowel_or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an alphabet
            Console.Write("Enter any alphabet: ");
            char alphabet = char.Parse(Console.ReadLine());

            // Convert the alphabet to lowercase to handle uppercase input
            alphabet = char.ToLower(alphabet);

            // Check if the entered character is a vowel
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("The alphabet is a vowel.");
            }
            // Check if the entered character is a letter (consonant)

            else if (char.IsLetter(alphabet))
            {
                Console.WriteLine("The alphabet is a consonant.");
            }
            else
            {
                Console.WriteLine("The input is not a valid alphabet.");
            }
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
