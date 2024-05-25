using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3namewriteline
{
    // Enter your name and from WriteLine function and print the output 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a string variable named uname
            Console.Write("Enter the name: ");
            string uname = Console.ReadLine();
            // Print the message along with the value of uname
            Console.WriteLine("Entered: " + uname);
            Console.ReadKey();
        }
    }
}
