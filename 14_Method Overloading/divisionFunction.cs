using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4divisionFunction
{
    class Calculator
    {
        // Method with two integer parameters
        public void Division(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine("Division of {0} by {1} is: {2}", a, b, (double)a / b);
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Division with two integer parameters
            Console.WriteLine("Enter the first integer for division by two integers: ");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            int int2 = int.Parse(Console.ReadLine());
            calc.Division(int1, int2);
            Console.ReadKey();
        }
    }
}
