using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1readOnlyProperty
{
    // Write a program on illustrating the read-only property by taking as class Employee in c#
    public class Employee
    {
        // Read-only field
        public string Name;

        // Read-only property
        private int _employeeId;
        public int EmployeeId
        {
            get { return _employeeId; }
        }

        // Constructor to initialize read-only fields and properties
        public Employee(string name, int employeeId)
        {
            Name = name;
            _employeeId = employeeId;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee emp = new Employee("Pavan", 045);

            // Display employee details
            emp.DisplayEmployeeDetails();
            Console.ReadKey();
        }
    }
}
