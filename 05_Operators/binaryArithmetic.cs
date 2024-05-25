using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Binary_Arithmetic
{
    // 1. Write the program to demonstrate the working of Binary Arithmetic Operators?
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompting user to input values for variables a and b
            Console.Write("Enter value for a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter value for b: ");
            int b = int.Parse(Console.ReadLine());

            // Performing binary arithmetic operations
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            int modulo = a % b;

            // Displaying results of the binary arithmetic operations
            Console.WriteLine();
            Console.WriteLine("Addition Operator: " + addition);
            Console.WriteLine("Subtraction Operator: " + subtraction);
            Console.WriteLine("Multiplication Operator: " + multiplication);
            Console.WriteLine("Division Operator: " + division);
            Console.WriteLine("Modulo Operator: " + modulo);

            // Waiting for user input before closing the console window
            Console.ReadKey();
        }
    }
}
