using System;
using System.Globalization;

namespace _01.NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            // 1. Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

            Console.Write("Enter a positive number from 1 to N: ");
            ulong N = ulong.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (ulong number = 1; number <= N; number++)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}
