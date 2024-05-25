using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Unary_Arithmatic_operators
{
    // 2.Write the program to demonstrate the working of Unary Arithmetic Operators ?
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompting user to input a value for variable a
            Console.Write("Enter value for a: ");
            int a = int.Parse(Console.ReadLine());

            // Demonstrating unary arithmetic operators

            int res1 = a++; 
            int res2 = a--; 
            int res3 = ++a; 
            int res4 = --a;
            // Displaying the results of unary arithmetic operators
            Console.WriteLine($"a++ is {a} and res is {res1}");
            Console.WriteLine($"a-- is {a} and res is {res2}");
            Console.WriteLine($"++a is {a} and res is {res3}");
            Console.WriteLine($"--a is {a} and res is {res4}");
            Console.ReadKey();
        }
    }
}
