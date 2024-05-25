using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceStringInReplaceFunction
{
    internal class Program
    {
        // Write a Program to Replace String in String using Replace function 
        static void Main(string[] args)
        {
            // Take user input for the original sentence
            Console.Write("Enter the sentence: ");
            string originalSentence = Console.ReadLine();

            // Take user input for the substring to be replaced
            Console.Write("Enter the substring to be replaced: ");
            string oldSubstring = Console.ReadLine();

            // Take user input for the new substring
            Console.Write("Enter the new substring: ");
            string newSubstring = Console.ReadLine();

            // Replacing the old substring with the new substring
            string newSentence = originalSentence.Replace(oldSubstring, newSubstring);

            // Display the sentences
            Console.WriteLine("Sentence Before Replacing: " + originalSentence);
            Console.WriteLine("Sentence After Replacing: " + newSentence);

            Console.ReadKey();
        }
    }
}
