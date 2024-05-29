using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1changeNumOfParameter
{
    // Define a program on overloading by changing the Number of parameters.
    class Calculator
    {
        // Method with one integer parameter
        public int Calculate(int a)
        {
            return a * a; // Return the square of the integer
        }

        // Method with two integer parameters
        public int Calculate(int a, int b)
        {
            return a + b; // Return the sum of the two integers
        }

        // Method with three integer parameters
        public int Calculate(int a, int b, int c)
        {
            return a + b + c; // Return the sum of the three integers
        }

        // Method with no parameters
        public int Calculate()
        {
            return 0; // Return zero when no parameters are provided
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Select the type of operation:");
            Console.WriteLine("1. Calculate() - No parameters");
            Console.WriteLine("2. Calculate(int) - One integer parameter");
            Console.WriteLine("3. Calculate(int, int) - Two integer parameters");
            Console.WriteLine("4. Calculate(int, int, int) - Three integer parameters");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int result0 = calc.Calculate();
                    Console.WriteLine("The result of Calculate() is: " + result0);
                    break;
                case 2:
                    Console.WriteLine("Enter one integer: ");
                    int int1 = int.Parse(Console.ReadLine());
                    int result1 = calc.Calculate(int1);
                    Console.WriteLine("The result of Calculate({0}) is: {1}", int1, result1);
                    break;
                case 3:
                    Console.WriteLine("Enter the first integer: ");
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second integer: ");
                    int int3 = int.Parse(Console.ReadLine());
                    int result2 = calc.Calculate(int2, int3);
                    Console.WriteLine("The result of Calculate({0}, {1}) is: {2}", int2, int3, result2);
                    break;
                case 4:
                    Console.WriteLine("Enter the first integer: ");
                    int int4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second integer: ");
                    int int5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the third integer: ");
                    int int6 = int.Parse(Console.ReadLine());
                    int result3 = calc.Calculate(int4, int5, int6);
                    Console.WriteLine("The result of Calculate({0}, {1}, {2}) is: {3}", int4, int5, int6, result3);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
