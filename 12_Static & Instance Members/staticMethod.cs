using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2staticMethod
{
    // Define a static method and access that through a instance
    internal class Program
    {
        public class MyClass
        {
            // Define a static method
            public static void MyStaticMethod()
            {
                Console.WriteLine("This is a static method.");
            }
        }
        static void Main(string[] args)
        {
            // Access the static method through the class name (recommended way)
            MyClass.MyStaticMethod();

            // Create an instance of the class
            MyClass instance = new MyClass();

            // Access the static method through an instance (possible but not recommended)
            instance.MyStaticMethod();
        }
    }
}
