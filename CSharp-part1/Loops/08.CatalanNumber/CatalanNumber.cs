using System;
using System.Globalization;
using System.Numerics;

namespace _08.CatalanNumber
{
    class CatalanNumber
    {
        static void Main()
        {
            // 8. In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/6.%20Loops/README.md
            //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

            Console.Write("Enter an integer number N: ");
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (N < 0 || N > 100)
            {
                Console.WriteLine("Invalid input numbers. You should have enter (1 < k < n < 100)");
                return;
            }

            BigInteger result = 0;
            BigInteger divisor = 1;
            BigInteger factorialN = 1;
            BigInteger factorialDoubleN = 1;

            for (int i = 1; i <= 2 * N; i++)
            {
                factorialDoubleN *= i;

                if (i <= N)
                {
                    factorialN *= i;
                }
            }

            for (int i = 1; i <= (N + 1); i++)
            {
                divisor *= i;
            }
            result = (factorialDoubleN / (divisor * factorialN));
            Console.WriteLine("The catalan number is: {0}", result);
        }
    }
}
