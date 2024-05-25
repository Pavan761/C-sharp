using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _5Create_multiple_obj
{
    // Write a program on creating multiple objects of one class in c#.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create multiple instances of the Car class
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            // Prompt the user to enter details for Car 1
            Console.WriteLine("Enter details for Car 1:");
            Console.Write("Enter car make: ");
            car1.Make = Console.ReadLine();
            Console.Write("Enter car model: ");
            car1.Model = Console.ReadLine();
            Console.Write("Enter car year: ");
            car1.Year = int.Parse(Console.ReadLine());
            Console.Write("Enter car color: ");
            car1.color = Console.ReadLine();
            Console.Write("Enter car max speed: ");
            car1.maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Prompt the user to enter details for Car 2
            Console.WriteLine("Enter details for Car 2:");
            Console.Write("Enter car make: ");
            car2.Make = Console.ReadLine();
            Console.Write("Enter car model: ");
            car2.Model = Console.ReadLine();
            Console.Write("Enter car year: ");
            car2.Year = int.Parse(Console.ReadLine());
            Console.Write("Enter car color: ");
            car2.color = Console.ReadLine();
            Console.Write("Enter car max speed: ");
            car2.maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine();


            // Prompt the user to enter details for Car 3
            Console.WriteLine("Enter details for Car 3:");
            Console.Write("Enter car make: ");
            car3.Make = Console.ReadLine();
            Console.Write("Enter car model: ");
            car3.Model = Console.ReadLine();
            Console.Write("Enter car year: ");
            car3.Year = int.Parse(Console.ReadLine());
            Console.Write("Enter car color: ");
            car3.color = Console.ReadLine();
            Console.Write("Enter car max speed: ");
            car3.maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Print details of each car
            Console.WriteLine("\nDetails of Car 1:");
            car1.PrintDetails();

            Console.WriteLine("\nDetails of Car 2:");
            car2.PrintDetails();

            Console.WriteLine("\nDetails of Car 3:");
            car3.PrintDetails();
            Console.ReadKey();
        }
        class Car
        {
            private string make;
            private string model;
            public string color;
            public int maxSpeed;

            // Public properties for make, model, and year
            public string Make
            {
                get { return make; }
                set { make = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public int Year { get; set; }

            // Method to print the details of the car
            public void PrintDetails()
            {
                Console.WriteLine("Car Details:");
                Console.WriteLine("Make: " + Make);
                Console.WriteLine("Model: " + Model);
                Console.WriteLine("Year: " + Year);
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Max Speed: " + maxSpeed);
            }
        }
    }
}
