using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2protectedAccessModifier
{
    // Write a program on protected access modifier using one method in c#

    public class BaseClass
    {
        // Protected method
        protected int GetValue()
        {
            // For demonstration, return a fixed value
            return 10;
        }
    }

    public class DerivedClass : BaseClass
    {
        // Public method to access the protected method of the base class
        public void ShowValue()
        {
            int value = GetValue(); // Calling the protected method
            Console.WriteLine($"Output : {value}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the derived class
            DerivedClass derived = new DerivedClass();

            // Prompt the user to enter a value for demonstration purposes
            Console.WriteLine("Input : Enter value of x");

            // Read input (we won't actually use this value in the example)
            string input = Console.ReadLine();

            // Call the method to show the value
            derived.ShowValue();
            Console.ReadKey();
        }
    }
}
