using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1staticVariable
{
    // Define a static variable and access that through class name.
    public class MyClass
    {
        // Define a static variable
        public static int MyStaticVariable = 42;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Access the static variable through the class name and display the initial value
            Console.WriteLine("Initial value of MyStaticVariable: " + MyClass.MyStaticVariable);

            // Prompt the user for input
            Console.Write("Enter a new value for MyStaticVariable: ");
            string userInput = Console.ReadLine();

            // Parse the user input to an integer
            if (int.TryParse(userInput, out int newValue))
            {
                // Modify the static variable with the user input
                MyClass.MyStaticVariable = newValue;

                // Display the modified static variable
                Console.WriteLine("Updated value of MyStaticVariable: " + MyClass.MyStaticVariable);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.ReadKey();
        }
    }
}
