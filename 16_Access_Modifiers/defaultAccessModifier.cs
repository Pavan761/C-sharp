using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4defaultAccessModifier
{
    // Write a program on default access modifier in c#

    class Person
    {
        // These fields are implicitly private because they do not have explicit access modifiers
        string name;
        int age;

        // Constructor to initialize the name and age
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Method to display the person's details (this method is implicitly private)
        void DisplayDetails()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }

        // Public method to call the private DisplayDetails method
        public void ShowDetails()
        {
            DisplayDetails();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the name
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            // Prompt the user to enter the age
            Console.Write("Enter the age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Please enter a valid age.");
                Console.Write("Enter the age: ");
            }

            // Create an instance of the Person class with user input
            Person person = new Person(name, age);

            // Call the public method to show the details
            person.ShowDetails();

            Console.WriteLine();
            // Wait for a key press before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
