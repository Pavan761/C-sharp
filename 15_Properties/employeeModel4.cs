using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4employeeModel4
{
    // Create an object for the above EmployeeModel and assign the values to all properties and print each property on console
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of EmployeeModel
            EmployeeModel employee = new EmployeeModel();

            // Read input for each property from the user
            Console.Write("Enter Employee ID: ");
            employee.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Enter Employee Position: ");
            employee.Position = Console.ReadLine();

            Console.Write("Enter Employee Date of Birth (yyyy-mm-dd): ");
            employee.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Employee Salary: ");
            employee.Salary = decimal.Parse(Console.ReadLine());

            // Print each property to the console
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"ID: {employee.Id}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Position: {employee.Position}");
            Console.WriteLine($"Date of Birth: {employee.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Salary: {employee.Salary:C}");
            Console.ReadKey();
        }
    }
}
