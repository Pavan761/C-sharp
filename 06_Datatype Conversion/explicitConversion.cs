using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Explicit_Conversion
{
    // 2. Write an example of explicit type conversion.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a double value
            Console.Write("Enter Value of I: ");
            double doubleValue = double.Parse(Console.ReadLine());

            // Convert the double value to an integer
            int intValue = (int)doubleValue;

            // Display the integer value
            Console.WriteLine("Value of I is " + intValue);
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
