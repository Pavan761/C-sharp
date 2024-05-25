using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortStringInAscending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Take user input for the string
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();

            // Convert the input string to a character array
            char[] charArray = inputString.ToCharArray();

            // Call the function to sort the character array
            SortCharArray(charArray);

            // Convert the sorted character array back to a string with spaces between characters
            string sortedString = String.Join(" ", charArray);

            // Display the result
            Console.WriteLine("After sorting the string appears like: " + sortedString);

            Console.ReadKey();
        }
        static void SortCharArray(char[] ar)
        {
            // Implementing simple bubble sort algorithm to sort the array
            int n = ar.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (ar[j] > ar[j + 1])
                    {
                        // Swap array[j] and array[j + 1]
                        char temp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = temp;
                    }
                }
            }
        }
    }
}
