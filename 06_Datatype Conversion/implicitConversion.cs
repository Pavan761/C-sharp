using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Implicit_Conversion
{
    // 1. Write a program to Implicit Type Conversion
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an integer value
            Console.Write("Enter Int value: ");
            int intValue = int.Parse(Console.ReadLine());

            // Implicit type conversion: int to long
            long longValue = intValue;

            Console.WriteLine("Int value - " + intValue);
            Console.WriteLine("Long value - " + longValue);
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
