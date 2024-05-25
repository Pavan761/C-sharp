using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic_Assignment
{
    internal class _1empId
    {
        //Declare a variable of data type int with name empID  
        static void Main()
        {
            // Prompt the user to enter an employee ID
            Console.Write("Enter a empid: ");
            // Read the input from the user and parse it into an integer
            int empId = int.Parse(Console.ReadLine());
            // Declare a string variable named empName and initialize it with the value "Pavan"
            String empName = "Pavan";
             // Print the entered employee name
            Console.WriteLine("Entered name is: " + empName);
            // Wait for the user to press a key before closing the console window
            Console.ReadKey();

        }

    }
}
