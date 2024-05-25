using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2booleantype
{
    internal class Program
    {
        // 02_Write a program in boolean type and print in console
        static void Main(string[] args)
        {
            // Prompt the user to enter the first name
            Console.Write("Enter 1st name: ");
            // Read the first name from the user input
            string name1 = Console.ReadLine();

            // Prompt the user to enter the second name
            Console.Write("Enter 2nd name: ");
            // Read the second name from the user input
            string name2 = Console.ReadLine();

            // Compare the two names
            if (name1 == name2)
            {
                // If the names are equal, print "True"
                Console.WriteLine("True");
            }
            else
            {
                // If the names are not equal, print "False"
                Console.WriteLine("False");
            }

            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
