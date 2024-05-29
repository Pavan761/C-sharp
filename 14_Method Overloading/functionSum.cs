using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3functionSum
{
    // Define a program on a function Sum() that accepts values as a parameter and print their addition.
    class Calculator
    {
        // Method with two integer parameters
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, a + b);
        }

        // Method with two double parameters
        public void Sum(double a, double b)
        {
            Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, a + b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Select the type of operation:");
            Console.WriteLine("1. Sum(int, int)");
            Console.WriteLine("2. Sum(double, double)");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the first integer: ");
                    int int1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second integer: ");
                    int int2 = int.Parse(Console.ReadLine());
                    calc.Sum(int1, int2);
                    break;
                case 2:
                    Console.WriteLine("Enter the first double: ");
                    double double1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second double: ");
                    double double2 = double.Parse(Console.ReadLine());
                    calc.Sum(double1, double2);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }  
            Console.ReadKey();
        }
    }
}
