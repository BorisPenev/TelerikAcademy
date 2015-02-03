using System;
using System.Globalization;

namespace _02.NumbersNotDivisibleByThreeAndSeven
{
    class NumbersNotDivisibleByThreeAndSeven
    {
        static void Main(string[] args)
        {
            // 2. Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7,
            //    on a single line, separated by a space.
            Console.Write("Enter a positive number from 1 to N: ");
            ulong N = ulong.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (ulong number = 1; number <= N; number++)
            {
                if (!((number  % 5 == 0) || (number % 7 == 0)))
                {                    
                    Console.Write("{0} ", number);
                }
            }
        }
    }
}
