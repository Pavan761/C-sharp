using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5employeeModel5
{
    // Create another object for the above EmployeeModel and assign different values to all properties and print each property on console

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
            // Create the first instance of EmployeeModel and assign values
            EmployeeModel employee1 = new EmployeeModel();

            Console.Write("Enter Employee 1 ID: ");
            employee1.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee 1 Name: ");
            employee1.Name = Console.ReadLine();

            Console.Write("Enter Employee 1 Position: ");
            employee1.Position = Console.ReadLine();

            Console.Write("Enter Employee 1 Date of Birth (yyyy-mm-dd): ");
            employee1.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Employee 1 Salary: ");
            employee1.Salary = decimal.Parse(Console.ReadLine());

            // Print the properties of the first employee
            Console.WriteLine("\nEmployee 1 Details:");
            Console.WriteLine($"ID: {employee1.Id}");
            Console.WriteLine($"Name: {employee1.Name}");
            Console.WriteLine($"Position: {employee1.Position}");
            Console.WriteLine($"Date of Birth: {employee1.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Salary: {employee1.Salary:C}");

            // Create the second instance of EmployeeModel and assign values
            EmployeeModel employee2 = new EmployeeModel();

            Console.Write("\nEnter Employee 2 ID: ");
            employee2.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee 2 Name: ");
            employee2.Name = Console.ReadLine();

            Console.Write("Enter Employee 2 Position: ");
            employee2.Position = Console.ReadLine();

            Console.Write("Enter Employee 2 Date of Birth (yyyy-mm-dd): ");
            employee2.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Employee 2 Salary: ");
            employee2.Salary = decimal.Parse(Console.ReadLine());

            // Print the properties of the second employee
            Console.WriteLine("\nEmployee 2 Details:");
            Console.WriteLine($"ID: {employee2.Id}");
            Console.WriteLine($"Name: {employee2.Name}");
            Console.WriteLine($"Position: {employee2.Position}");
            Console.WriteLine($"Date of Birth: {employee2.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Salary: {employee2.Salary:C}");
            Console.ReadKey();
        }
    }
}
