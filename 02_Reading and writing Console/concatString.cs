using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4concat2strg
{
    //Declare a 2 strings as input and contacenate with another string with the both Strings and get Output
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user to enter their first name
            Console.Write("enter fname: ");
            string fname = Console.ReadLine();
            // Prompting the user to enter their last name
            Console.Write("Enter Lname: ");
            string lname = Console.ReadLine();
            // Displaying a greeting message with the entered first and last names
            Console.WriteLine("Hello" + " " + fname + " " + lname);
            // Waiting for user input before closing the console window
            Console.ReadKey();
        }
    }
}
