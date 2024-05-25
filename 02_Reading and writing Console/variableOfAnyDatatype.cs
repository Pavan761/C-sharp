using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2declarename
{
    //Declare a variable name of any datatype and read the name in the output 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a string variable named name.
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //Print the message along with the value of name
            Console.WriteLine("You entered: " + name);
            Console.ReadKey();
        }
    }
}
