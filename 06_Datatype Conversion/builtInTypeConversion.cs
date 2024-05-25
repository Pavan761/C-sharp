using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Built_in_type_conversion
{
    // 3. Write a program of built in type conversion methods
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a string representing a float value
            Console.Write("Enter a string representing a float value: ");
            string stringValue = Console.ReadLine();

            // Prompt the user to enter an integer value
            Console.Write("Enter an integer value: ");
            int intValue = int.Parse(Console.ReadLine());

            // Convert string to float using Parse method
            float floatValue = float.Parse(stringValue);

            // Convert int to double using Convert class
            double doubleValue = Convert.ToDouble(intValue);

            Console.WriteLine("string to float - " + floatValue);
            Console.WriteLine("int to double - " + doubleValue);
            Console.ReadKey();
        }
    }
}
