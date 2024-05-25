using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _4Creat_of_obj_car_class
{
    // Create an object of the Car class, with the name myObj. Then we print the value of the fields color and maxSpeed.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Car class named myObj
            Car myObj = new Car();

            // Prompt the user to enter car details
            Console.Write("Enter car make: ");
            myObj.Make = Console.ReadLine();

            Console.Write("Enter car model: ");
            myObj.Model = Console.ReadLine();

            Console.Write("Enter car year: ");
            myObj.Year = int.Parse(Console.ReadLine());

            Console.Write("Enter car color: ");
            myObj.color = Console.ReadLine();

            Console.Write("Enter car max speed: ");
            myObj.maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Print details of the car using the PrintDetails method
            myObj.PrintDetails();

            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
            
        }
        class Car
        {
            // Private fields for make and model
            private string make;
            private string model;
            public string color; 
            public int maxSpeed; 
            
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
