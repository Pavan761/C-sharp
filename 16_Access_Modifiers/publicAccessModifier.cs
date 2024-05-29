using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1publicAccessModifier
{
    // Write a program to show the use of public Access Modifier in c#

    public class Student
    {
        // Using public access modifiers to allow access from outside the class
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Student class
            Student student = new Student();

            // Prompt the user to enter the student details
            Console.WriteLine("Enter the details of the student:");

            Console.Write("Student ID: ");
            student.StudentId = int.Parse(Console.ReadLine());

            Console.Write("Student Name: ");
            student.StudentName = Console.ReadLine();

            // Display the entered details
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Student ID: {student.StudentId}");
            Console.WriteLine($"Student Name: {student.StudentName}");
            Console.ReadKey();
        }
    }
}
