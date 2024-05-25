using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3convertfloattodecimal
{
    internal class Program
    {
        // 03_Write a program on converting Float to Decimal type and print in console
        static void Main(string[] args)
        {
            // Declare and initialize a float variable
            float floatnum = 12.98F;

            // Convert the float variable to a decimal type
            decimal decnum = (decimal)floatnum;

            // Print the original float value to the console
            Console.WriteLine("Float: " + floatnum);

            // Print the converted decimal value to the console
            Console.WriteLine("Decimal: " + decnum);
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();

        }
    }
}
