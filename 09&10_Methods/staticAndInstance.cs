using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Static_and_Instance
{
    // 2. Write a program on static and instance methods in c#.
    internal class Program
    {
        // Static method example
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }
        // Instance method example
        public void InstanceMethod()
        {
            Console.WriteLine("This is an instance method.");
        }
    }

    class moProgram
    {
        static void Main()
        {
            // Calling a static method using the class name
            Program.StaticMethod();

            // Creating an instance of the Program class
            Program myObject = new Program();


            // Calling an instance method using the object of the class
            myObject.InstanceMethod();
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
