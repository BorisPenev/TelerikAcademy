using System;
using System.Globalization;

namespace _1.SumOfThreeNumbers
{
    class Program
    {
        static void Main()
        {
            // 1. Write a program that reads 3 real numbers from the console and prints their sum.

            Console.Write("Enter First Number: ");
            double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter Second Number: ");

            double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter Third Number: ");
            double thirdNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
