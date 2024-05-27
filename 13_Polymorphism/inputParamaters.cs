using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1inputParamaters
{
    // Write a program on A class has two methods with the same name "Add" but with different input parameters(the first method has three parameters and the second method has two parameters) in c#
    internal class Program
    {
        // Method with three parameters
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method with two parameters
        public int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Enter the number of inputs (2 or 3): ");
            int numOfInputs = int.Parse(Console.ReadLine());

            if (numOfInputs == 2)
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = program.Add(num1, num2);
                Console.WriteLine("The result of Add({0}, {1}) is: {2}", num1, num2, result);
            }
            else if (numOfInputs == 3)
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the third number: ");
                int num3 = int.Parse(Console.ReadLine());

                int result = program.Add(num1, num2, num3);
                Console.WriteLine("The result of Add({0}, {1}, {2}) is: {3}", num1, num2, num3, result);
            }
            else
            {
                Console.WriteLine("Invalid number of inputs. Please enter either 2 or 3.");
            }
            Console.ReadKey();
        }
    }
}
