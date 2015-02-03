using System;
using System.Globalization;

namespace _06.CalculateNK
{
    class CalculateNK
    {
        static void Main()
        {
            // 6. Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            // Use only one loop.

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
            Console.WriteLine("Result: {0}", result);
        }
    }
}
