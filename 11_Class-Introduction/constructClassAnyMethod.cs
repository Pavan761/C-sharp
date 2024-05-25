using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Construct_class_any_method
{
    // Construct a class using any methods for employee details using its parameters and print Output.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee emp = new Employee();

            // Prompt the user to enter employee details
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employee age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter employee department: ");
            string department = Console.ReadLine();

            Console.Write("Enter employee salary: ");
            double salary = double.Parse(Console.ReadLine());

            emp.SetDetails(name, age, department, salary);

            // Print the details of the employee
            emp.PrintDetails();
            Console.ReadKey();
        }
        // Employee class: Represents an employee object
        class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }            

            public void SetDetails(string name, int age, string department, double salary)
            {
                // Set the values of the properties
                Name = name;
                Age = age;
                Department = department;
                Salary = salary;
                Console.WriteLine();
            }
            // Method to print the details of the employee
            public void PrintDetails()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Department: " + Department);
                Console.WriteLine("Salary: " + Salary);
            }
        }
    }
}
