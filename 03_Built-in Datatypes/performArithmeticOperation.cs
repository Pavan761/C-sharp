using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4performoperation
{
    internal class Program
    {
        static void Main()
        {
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");

            // Read the user's input and convert it to decimal
            string input1 = Console.ReadLine();
            decimal firstNumber = ConvertToDecimal(input1);


            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");

            // Read the user's input and convert it to decimal
            string input2 = Console.ReadLine();
            decimal secondNumber = ConvertToDecimal(input2);

            // Prompt the user to enter an operation
            Console.Write("Enter an operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            decimal result;
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                    break;
                case '/':
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter one of the following operations: +, -, *, /.");
                    break;
            }
                    Console.ReadKey();
        }

        static decimal ConvertToDecimal(string input)
        {
            bool isNegative = false;
            int startIndex = 0;
            decimal result = 0;
            decimal fractionPart = 0;
            bool fraction = false;
            decimal divisorForFraction = 1;

            // Check if the number is negative or positive
            if (input.Length > 0 && (input[0] == '-' || input[0] == '+'))
            {
                isNegative = input[0] == '-';
                startIndex = 1;
            }


            // Iterate through each character in the input string
            for (int i = startIndex; i < input.Length; i++)
            {
                // Check if the character is a decimal point
                if (input[i] == '.')
                {
                    if (fraction) throw new FormatException("Invalid format: multiple decimal points.");
                    fraction = true;
                    continue;
                }

                if (input[i] < '0' || input[i] > '9')
                {
                    throw new FormatException("Invalid format: non-numeric character.");
                }

                int digit = input[i] - '0';

                if (!fraction)
                {
                    result = result * 10 + digit;
                }
                else
                {
                    divisorForFraction *= 10;
                    fractionPart = fractionPart * 10 + digit;
                }
            }
            // Add the fraction part to the result
            result += fractionPart / divisorForFraction;

            // Adjust the result if it's negative
            if (isNegative)
            {
                result = -result;
            }

            return result;
            
        }
    }
}

