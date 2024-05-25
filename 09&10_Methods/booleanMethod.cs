using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Boolean_Method
{
    // 1. Write a program using WriteLine(Boolean) method in c#
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a boolean value for the first condition
            Console.Write("Enter 'true' or 'false' for the first condition: ");
            Console.Write("\nIs it sunny? ");
            bool Sunny = bool.Parse(Console.ReadLine());

            // Prompt the user to enter a boolean value for the second condition 
            Console.Write("Enter 'true' or 'false' for the second condition: ");
            Console.Write("\nIs it raining? ");
            bool Raining = bool.Parse(Console.ReadLine());

            // Display the first condition 
            Console.WriteLine("Is it sunny?");
            Console.WriteLine(Sunny);

            // Display the second condition 
            Console.WriteLine("Is it raining?");
            Console.WriteLine(Raining);
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
