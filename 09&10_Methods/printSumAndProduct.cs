using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Print_sum___Product
{
    // Write a method of Calculator and print sum and product in c#.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator calculator = new Calculator();

            // Prompt the user to enter the value for 'a'
            Console.Write("Enter value for a: ");
            int a = int.Parse(Console.ReadLine());

            // Prompt the user to enter the value for 'b'
            Console.Write("Enter value for b: ");
            int b = int.Parse(Console.ReadLine());

            // Calculate the sum of 'a' and 'b' using the Sum method of the Calculator class
            int sum = calculator.Sum(a, b);
            // Calculate the product of 'a' and 'b' using the Product method of the Calculator class
            int product = calculator.Product(a, b);

            Console.WriteLine("sum of the values are = " + sum + " and product of the values are = " + product);
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
        class Calculator
        {
            // Method to calculate the sum of two integers
            public int Sum(int a, int b)
            {
                int result = a + b;
                return result;
            }
            // Method to calculate the product of two integers
            public int Product(int a, int b)
            {
                int result = a * b;
                return result;
            }
        }
    }
}
