using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5addingoutput
{
    //Write a program by taking two integer values and return the value by adding in the Output
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompting user to enter the first integer value
            Console.Write("Enter 1st int: ");
            int num1 = int.Parse(Console.ReadLine());
            // Prompting user to enter the second integer value
            Console.Write("Enter the num2: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Output: " + sum);

            // Waiting for user input before closing the console window
            Console.ReadKey();
        }
    }
}
