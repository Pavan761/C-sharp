using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4staticVariable
{
    // Define a static variable and change within the class in c#
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
            staticCounter = 100; // Initialize static variable
        }

        // Instance constructor
        public ExampleClass(int initialValue)
        {
            Console.WriteLine("Instance constructor called.");
            instanceCounter = initialValue;
            IncrementStaticCounter(); // Modify static variable within instance constructor
        }

        // Static method to modify the static variable
        public static void IncrementStaticCounter()
        {
            staticCounter++;
            Console.WriteLine($"Static counter incremented. New value: {staticCounter}");
        }

        // Instance method to modify the static variable
        public void DecrementStaticCounter()
        {
            staticCounter--;
            Console.WriteLine($"Static counter decremented. New value: {staticCounter}");
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
            // Create first instance and modify static variable
            ExampleClass obj1 = new ExampleClass(1);
            obj1.Display();

            // Create second instance and modify static variable
            ExampleClass obj2 = new ExampleClass(2);
            obj2.Display();

            // Modify static variable using static method
            ExampleClass.IncrementStaticCounter();

            // Modify static variable using instance method
            obj2.DecrementStaticCounter();

            // Access static variable directly through the class
            Console.WriteLine($"Static Counter accessed via class: {ExampleClass.staticCounter}");
            Console.ReadKey();
        }
    }
}
