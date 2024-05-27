using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5overridingByChangeInOrder
{
    // 5. Write a program to demonstrate the function overloading by changing the Order of the parameters in c#
    class Calculator
    {
        // Method with parameters in the order: int, double
        public void Display(int a, double b)
        {
            Console.WriteLine("Int: {0}, Double: {1}", a, b);
        }

        // Method with parameters in the order: double, int
        public void Display(double a, int b)
        {
            Console.WriteLine("Double: {0}, Int: {1}", a, b);
        }

        // Method with parameters in the order: string, int
        public void Display(string a, int b)
        {
            Console.WriteLine("String: {0}, Int: {1}", a, b);
        }

        // Method with parameters in the order: int, string
        public void Display(int a, string b)
        {
            Console.WriteLine("Int: {0}, String: {1}", a, b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Select the type of operation:");
            Console.WriteLine("1. Display(int, double)");
            Console.WriteLine("2. Display(double, int)");
            Console.WriteLine("3. Display(string, int)");
            Console.WriteLine("4. Display(int, string)");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter an integer: ");
                    int int1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a double: ");
                    double double1 = double.Parse(Console.ReadLine());
                    calc.Display(int1, double1);
                    break;
                case 2:
                    Console.WriteLine("Enter a double: ");
                    double double2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter an integer: ");
                    int int2 = int.Parse(Console.ReadLine());
                    calc.Display(double2, int2);
                    break;
                case 3:
                    Console.WriteLine("Enter a string: ");
                    string str1 = Console.ReadLine();
                    Console.WriteLine("Enter an integer: ");
                    int int3 = int.Parse(Console.ReadLine());
                    calc.Display(str1, int3);
                    break;
                case 4:
                    Console.WriteLine("Enter an integer: ");
                    int int4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a string: ");
                    string str2 = Console.ReadLine();
                    calc.Display(int4, str2);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
