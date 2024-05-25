using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1intdatatype
{
    internal class Program
    {
        // 01_Declare a value as int datatype and print in the output
        static void Main(string[] args)
        {
            Console.WriteLine();
            // Prompt the user to enter an integer
            Console.Write("Enter the integer: ");

            // Read the user's input from the console and parse it to an integer
            int num = int.Parse(Console.ReadLine());

            // Print the entered integer to the console
            Console.WriteLine("Entered integer is: " + num);

            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
