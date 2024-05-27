using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3staticInstancevariableConstructor
{
    // Define a static and instance variable constructors and invoke the instance constructor
    public class ExampleClass
    {
        // Static variable
        public static int staticCounter = 0;

        // Instance variable
        public int instanceCounter;

        // Static constructor
        static ExampleClass()
        {
            Console.WriteLine("Static constructor called.");
            staticCounter = 100;
        }

        // Instance constructor
        public ExampleClass(int initialValue)
        {
            Console.WriteLine("Instance constructor called.");
            instanceCounter = initialValue;
        }

        public void Display()
        {
            Console.WriteLine($"Static Counter: {staticCounter}, Instance Counter: {instanceCounter}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get input from the user
            Console.Write("Enter a value for the instance counter: ");
            int userInput1 = int.Parse(Console.ReadLine());

            // Invoke instance constructor with user input
            ExampleClass obj1 = new ExampleClass(userInput1);
            obj1.Display();

            // Get another input from the user
            Console.Write("Enter another value for the instance counter: ");
            int userInput2 = int.Parse(Console.ReadLine());

            // Invoke instance constructor with second user input
            ExampleClass obj2 = new ExampleClass(userInput2);
            obj2.Display();

            // Access static variable directly through the class
            Console.WriteLine($"Static Counter accessed via class: {ExampleClass.staticCounter}");
            Console.ReadKey();
        }

    }
}
