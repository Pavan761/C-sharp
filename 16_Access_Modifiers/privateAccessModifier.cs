using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3privateAccessModifier
{
    // Write a program on private access modifier in c#

    class Person
    {
        // Private fields
        private string name;
        private int age;

        // Public method to set the name
        public void SetName(string name)
        {
            this.name = name;
        }

        // Public method to get the name
        public string GetName()
        {
            return name;
        }

        // Public method to set the age
        public void SetAge(int age)
        {
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Please enter a valid age.");
            }
        }

        // Public method to get the age
        public int GetAge()
        {
            return age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person person = new Person();

            // Prompt the user to enter the name
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            person.SetName(name);

            // Prompt the user to enter the age
            Console.Write("Enter the age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Please enter a valid age.");
                Console.Write("Enter the age: ");
            }
            person.SetAge(age);
            Console.WriteLine();

            // Get and print the name and age using public methods
            Console.WriteLine("Name: " + person.GetName());
            Console.WriteLine("Age: " + person.GetAge());
            Console.ReadKey();
        }
    }
}
