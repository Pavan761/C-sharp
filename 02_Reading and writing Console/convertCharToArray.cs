using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6convertchararray
{
    internal class Program
    {
        // Write a program to enter password by converting it to char array into string print the Output
        static void Main(string[] args)
        {
            // Prompt the user to enter the password
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();

            // Convert the password to a char array
            char[] ch = new char[password.Length];
            for (int i = 0; i < password.Length; i++)
            {
                ch[i] = password[i];
            }
            // Convert the char array back to a string
            string passwordString = " ";
            for (int i = 0; i < ch.Length; i++)
            {
                passwordString += ch[i];
            }

            // Print the password
            Console.WriteLine("Password: " + passwordString);

            Console.ReadKey();
        }
    }
}
