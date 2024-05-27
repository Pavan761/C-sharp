using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sameMethodDifferentsign
{
    // Write a program on taking one method with same but different signature in the methods in c#
    class Calculator
    {
        // Method with two integer parameters
        public int Calculate(int a, int b)
        {
            return a + b;
        }

        // Method with three integer parameters
        public int Calculate(int a, int b, int c)
        {
            return a + b + c;
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Calling the Calculate method with two integers
            int result1 = calc.Calculate(5, 10);
            Console.WriteLine("The result of Calculate(5, 10) is: " + result1); // Output: 15

            // Calling the Calculate method with three integers
            int result2 = calc.Calculate(1, 2, 3);
            Console.WriteLine("The result of Calculate(1, 2, 3) is: " + result2); // Output: 6

            // Calling the Calculate method with two doubles
            double result3 = calc.Calculate(2.5, 4.0);
            Console.WriteLine("The result of Calculate(2.5, 4.0) is: " + result3); // Output: 10.0

            // Calling the Calculate method with a string and an integer
            string result4 = calc.Calculate("Number: ", 7);
            Console.WriteLine("The result of Calculate(\"Number: \", 7) is: " + result4); // Output: Number: 7
            Console.ReadKey();
        }
    }
}
