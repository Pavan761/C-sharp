using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empname
{
    internal class Program
    {
        //Declare a variable of data type string with name empName 
        static void Main(string[] args)
        {
            // Declare a string variable named empName
            string empName;
            // Assign the value "Pavan" to the empName variable
            empName = "Pavan";
            // Print the message along with the value of empName
            Console.WriteLine("Entered emp name is: " + empName);
            // Wait for the user to press a key before closing the console window
            Console.ReadKey();
         
        }
    }
}
