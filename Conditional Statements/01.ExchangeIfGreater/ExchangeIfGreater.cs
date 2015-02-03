using System;
using System.Globalization;

namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            // 1. Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.
            //      As a result print the values a and b, separated by a space.

            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (firstNumber > secondNumber)
            {
                firstNumber = firstNumber + secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber = firstNumber - secondNumber;
                Console.WriteLine("firstNumber: {0};   secondNumber: {1}", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("firstNumber: {0};   secondNumber: {1}", firstNumber, secondNumber);
            }

        }
    }
}
