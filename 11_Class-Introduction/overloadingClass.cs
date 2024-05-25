using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Overloading_class
{
    // Write a Program using overloading class constructor.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of employees
            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            // Create an array to store employee objects
            Employee[] employees = new Employee[numberOfEmployees];


            // Iterate through each employee and collect their details
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Enter details for employee {i + 1}:");
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter age (or press Enter to skip): ");
                string ageInput = Console.ReadLine();
                int age = string.IsNullOrEmpty(ageInput) ? 0 : int.Parse(ageInput);

                Console.Write("Enter department (or press Enter to skip): ");
                string department = Console.ReadLine();
                if (string.IsNullOrEmpty(department))
                    department = "Not Assigned";

                Console.Write("Enter salary (or press Enter to skip): ");
                string salaryInput = Console.ReadLine();
                double salary = string.IsNullOrEmpty(salaryInput) ? 0.0 : double.Parse(salaryInput);

                // Determine which overloaded constructor to use based on the provided inputs
                if (!string.IsNullOrEmpty(salaryInput))
                    employees[i] = new Employee(name, age, department, salary);
                else if (!string.IsNullOrEmpty(department))
                    employees[i] = new Employee(name, age, department);                
                else
                    employees[i] = new Employee(name);
                Console.WriteLine();
            }

            foreach (var emp in employees)
            {
                emp.PrintDetails();
                Console.WriteLine();
            }
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }

        class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }

            // Constructors

            // Default constructor
            public Employee()
            {
                Name = "Unknown";
                Age = 0;
                Department = "Not Assigned";
                Salary = 0.0;
            }

            // Constructor with name parameter
            public Employee(string name)
            {
                Name = name;
                Age = 0;
                Department = "Not Assigned";
                Salary = 0.0;
            }
            // Constructor with name, age, and department parameters
            public Employee(string name, int age, string department)
            {
                Name = name;
                Age = age;
                Department = department;
                Salary = 0.0;
            }

            // Constructor with all parameters
            public Employee(string name, int age, string department, double salary)
            {
                Name = name;
                Age = age;
                Department = department;
                Salary = salary;
            }
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
