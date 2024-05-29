using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3employeeModelWith5prop
{
    public class EmployeeModel
    {
        // Properties
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmailId { get; set; }
        public float Salary { get; set; }
        public bool IsEmployeeActive { get; set; }

        // Parameterized Constructor
        public EmployeeModel(int empId, string empName, string emailId, float salary, bool isEmployeeActive)
        {
            EmpId = empId;
            EmpName = empName;
            EmailId = emailId;
            Salary = salary;
            IsEmployeeActive = isEmployeeActive;
        }

        // Default Constructor
        public EmployeeModel()
        {
        }

        // Method to display employee details
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"EmpId: {EmpId}");
            Console.WriteLine($"EmpName: {EmpName}");
            Console.WriteLine($"EmailId: {EmailId}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"IsEmployeeActive: {IsEmployeeActive}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance using user input
            Console.WriteLine("Enter Employee ID:");
            int empId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Email ID:");
            string emailId = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Is Employee Active (true/false):");
            bool isEmployeeActive = bool.Parse(Console.ReadLine());

            EmployeeModel employee = new EmployeeModel(empId, empName, emailId, salary, isEmployeeActive);
            employee.DisplayEmployeeInfo();
            Console.ReadKey();
        }
    }
}
