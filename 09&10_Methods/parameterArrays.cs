using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Parameter_arrays
{
    // Write a program using parameter arrays and print output in console in c#.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter numbers separated by spaces
            Console.WriteLine("Enter numbers separated by spaces:");

            // Read the input string from the console
            string z = Console.ReadLine();

            // Split the input string into an array of number strings using space as delimiter
            string[] numberStrings = z.Split(' ');

            // Create an integer array to store the parsed numbers
            int[] numbers = new int[numberStrings.Length];
            // Parse each number string and store the integers in the 'numbers' array
            for (int i = 0; i < numberStrings.Length; i++)
            {
                numbers[i] = int.Parse(numberStrings[i]);
            }
            // Call the PrintNumbers method and pass the 'numbers' array as parameter
            PrintNumbers(numbers);
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
        static void PrintNumbers(params int[] numbers)
        {
            Console.WriteLine("Numbers:");

            // Iterate through the 'numbers' array and print each number
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
