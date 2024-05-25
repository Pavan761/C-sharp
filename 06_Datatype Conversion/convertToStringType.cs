using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Convert_to_Stringtype
{
    // 4. Write a program that converts various value types to string type.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an integer value
            Console.Write("Enter Integer value: ");
            int intValue = int.Parse(Console.ReadLine());

            // Prompt the user to enter a float value
            Console.Write("Enter Float value: ");
            float floatValue = float.Parse(Console.ReadLine());


            // Convert integer and float values to string using ToString() method
            string intString = intValue.ToString();
            string floatString = floatValue.ToString();

            Console.WriteLine("int.ToString() - " + intString);
            Console.WriteLine("float.ToString() - " + floatString);
            Console.ReadKey();
        }
    }
}
