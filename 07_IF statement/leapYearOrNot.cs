using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Leap_year_or_not
{
   // 2. Write a C# Sharp program to find whether a given year is a leap year or not. 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a year
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());


            // Check if the entered year is a leap year
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }

            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
