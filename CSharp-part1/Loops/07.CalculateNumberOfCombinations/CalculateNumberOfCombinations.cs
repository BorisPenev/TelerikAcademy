using System;
using System.Globalization;

namespace _07.CalculateNumberOfCombinations
{
    class CalculateNumberOfCombinations
    {
        static void Main()
        {
            // 7. In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations)
            // is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
            // Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

            Console.Write("Enter an integer number N: ");
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter an integer number K: ");
            double K = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (K < 1 || K > N || N > 100)
            {
                Console.WriteLine("Invalid input numbers. You should have enter (1 < k < n < 100)");
                return;
            }

            double result = 0;
            double divisor = 1;
            double factorialN = 1;
            double factorialK = 1;

            for (double i = 1; i <= N; i++)
            {
                factorialN *= i;

                if (i <= K)
                {
                    factorialK *= i;
                }

                result = (factorialN / factorialK);
            }

            for (int i = 1; i <= (N - K); i++)
            {
                divisor *= i;
            }

            result /= divisor;
            Console.WriteLine("The number of combinations is: {0}", result);
        }
    }
}
