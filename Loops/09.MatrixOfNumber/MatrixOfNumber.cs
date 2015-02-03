using System;
using System.Globalization;

namespace _09.MatrixOfNumber
{
    class MatrixOfNumber
    {
        static void Main()
        {
            // 9. Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below.
            // Use two nested loops.
            // Examples:
               
            // n = 2   matrix      n = 3   matrix      n = 4   matrix
            // 1 2                 1 2 3               1 2 3 4
            // 2 3                 2 3 4               2 3 4 5
            //                     3 4 5               3 4 5 6
            //                                         4 5 6 7
            
            Console.Write("Enter an integer number N: ");
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (N < 1 || N >20)
            {
                Console.WriteLine("Invalid number N, it should be in the interval (1 ≤ n ≤ 20)");
            }

            for (int row = 1; row <= N; row++)
            {
                for (int column = 0; column < N; column++)
                {
                    Console.Write("{0,2} ", row + column);
                }
                Console.WriteLine();
            }
        }
    }
}
