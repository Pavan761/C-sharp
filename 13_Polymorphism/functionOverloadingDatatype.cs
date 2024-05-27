using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4functionOverloadingdatatype
{
    // Write a program to demonstrate the function overloading by changing the Data types of the parameters in c#
    class Calculator
    {
        // Method with two integer parameters
        public int Calculate(int a, int b)
        {
            return a + b;
        }

        // Method with two double parameters
        public double Calculate(double a, double b)
        {
            return a * b;
        }

        // Method with a string and an integer parameter
        public string Calculate(string str, int num)
        {
            return str + num.ToString();
        }

        // Method with a double and an integer parameter
        public double Calculate(double a, int b)
        {
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Select the type of operation:");
            Console.WriteLine("1. Add two integers");
            Console.WriteLine("2. Multiply two doubles");
            Console.WriteLine("3. Concatenate a string with an integer");
            Console.WriteLine("4. Divide a double by an integer");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the first integer: ");
                    int int1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second integer: ");
                    int int2 = int.Parse(Console.ReadLine());
                    int result1 = calc.Calculate(int1, int2);
                    Console.WriteLine("The result of Calculate({0}, {1}) is: {2}", int1, int2, result1);
                    break;
                case 2:
                    Console.WriteLine("Enter the first double: ");
                    double double1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second double: ");
                    double double2 = double.Parse(Console.ReadLine());
                    double result2 = calc.Calculate(double1, double2);
                    Console.WriteLine("The result of Calculate({0}, {1}) is: {2}", double1, double2, result2);
                    break;
                case 3:
                    Console.WriteLine("Enter the string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("Enter the integer: ");
                    int int3 = int.Parse(Console.ReadLine());
                    string result3 = calc.Calculate(str, int3);
                    Console.WriteLine("The result of Calculate(\"{0}\", {1}) is: {2}", str, int3, result3);
                    break;
                case 4:
                    Console.WriteLine("Enter the double: ");
                    double double3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the integer: ");
                    int int4 = int.Parse(Console.ReadLine());
                    double result4 = calc.Calculate(double3, int4);
                    Console.WriteLine("The result of Calculate({0}, {1}) is: {2}", double3, int4, result4);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
