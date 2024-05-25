using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3For_Foreach_Loop
{
    // 3. By using Array write the program using For and Foreach loop in c#.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of elements in the array
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            // Create an array of strings with the specified size
            string[] ar = new string[n];
                        
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                ar[i] = Console.ReadLine();
            }

            // Using for loop
            Console.WriteLine("Array printing using for loop:");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();

            // Using foreach loop
            Console.WriteLine("Array printing using foreach loop:");
            foreach (string element in ar)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
