using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MinMaxAndAvarageNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = 3;
            List<int> numbers = new List<int>();

            while (N > 0)
            {
                numbers.Add(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                N--;
            }
            double average = numbers.Average();
            Console.WriteLine(numbers.Max());

            Console.WriteLine(numbers.Min());
            Console.WriteLine("{0:F3}", average);
        }
    }
}
