using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03.MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            // 3. Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
            //    the sum and the average of all numbers (displayed with 2 digits after the decimal point).
            //    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

            Console.Write("Enter a positive number from 1 to N: ");
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            List<int> numbers = new List<int>();

            while (N > 0)
            {
                Console.Write("Enter number: ");
                numbers.Add(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                N--;
            }

            Console.WriteLine("Min = {0}",numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Avg = {0}", numbers.Average().ToString("0.00"));
        }
    }
}
