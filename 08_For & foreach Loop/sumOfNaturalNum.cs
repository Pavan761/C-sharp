using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Sumof_natural_num
{
    // 1. Write a program in C# Sharp to display n terms of natural number and their sum.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of natural terms
            Console.Write("Enter number of natural terms you want: ");
            int n = int.Parse(Console.ReadLine());

            // Initialize a variable to store the sum of natural numbers
            int sum = 0;

            // Display the first n natural numbers
            Console.WriteLine("The first {0} natural number(s) is/are:", n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                sum =  sum + i;
            }

            Console.WriteLine("\nThe Sum of Natural Number upto {0} terms: {1}", n, sum);
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
