using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Relational_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompting user to input values for variables a and b
            Console.Write("Enter value for a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter value for b: ");
            int b = int.Parse(Console.ReadLine());
            // Comparing the values of a and b using relational operators
            bool equal = a == b;
            bool greaterThan = a > b;
            bool lessThan = a < b;
            bool greaterThanOrEqual = a >= b;
            bool lessThanOrEqual = a <= b;
            bool notEqual = a != b;

            // Displaying the results of the relational operations
            Console.WriteLine("1. Equal to Operator: " + equal);
            Console.WriteLine("2. Greater than Operator: " + greaterThan);
            Console.WriteLine("3. Less than Operator: " + lessThan);
            Console.WriteLine("4. Greater than or Equal to: " + greaterThanOrEqual);
            Console.WriteLine("5. Lesser than or Equal to: " + lessThanOrEqual);
            Console.WriteLine("6. Not Equal to Operator: " + notEqual);
            // Waiting for user input before closing the console window
            Console.ReadKey();

        }
    }
}
