using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate
{
    class Calculate
    {
        static void Main()
        {
            // 5. Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
            //      Use only one loop. Print the result with 5 digits after the decimal point.

            Console.Write("Enter an integer number N: ");
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter an integer number X: ");
            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double sum = 1;
            double factorial = 1;

            for (double i = 1; i <= N; i++)
            {
                factorial *= i;
                sum += (factorial / (Math.Pow(X, i)));
            }
            Console.WriteLine("Sum: {0}", sum.ToString("0.00000"));
        }
    }
}
