using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowerCaseMethod
{
    internal class Program
    {
        // Write a Program to Convert Upper case to Lower Case using LowerCase method  
        static void Main(string[] args)
        {
            Console.Write("Enter the string in uppercase: ");
            string upperCaseString = Console.ReadLine();

            // Convert the string to lowercase
            string lowerCaseString = upperCaseString.ToLower();

            // Display the original and the lowercase string
            Console.WriteLine("String in Lowercase: " + lowerCaseString);

            Console.ReadKey();
        }
    }
}
