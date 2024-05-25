using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _3Class__fields_and_methods
{
    // Create a Car class with three class members and two fields and one method in c#.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Car class
            Car car = new Car();

            // Prompt the user to enter car details and set them in the car object
            Console.Write("Enter car make: ");
            car.Make = Console.ReadLine();

            Console.Write("Enter car model: ");
            car.Model = Console.ReadLine();

            Console.Write("Enter car year: ");
            car.Year = int.Parse(Console.ReadLine());

            car.PrintDetails();
            Console.ReadKey();
        }
        // Car class: Represents a car object
        class Car
        {
            // Private fields for make and model
            private string make;
            private string model;

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

            // Auto-implemented property for year
            public int Year { get; set; }

            // Method to print details of the car
            public void PrintDetails()
            {
                Console.WriteLine("Car Details:");
                Console.WriteLine("Make: " + Make);
                Console.WriteLine("Model: " + Model);
                Console.WriteLine("Year: " + Year);
            }
        }
    }
}
