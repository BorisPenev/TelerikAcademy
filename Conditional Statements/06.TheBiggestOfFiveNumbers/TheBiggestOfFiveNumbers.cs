using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        { 
            // 6. Write a program that finds the biggest of five numbers.
            List<int> numbers = new List<int>();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter {0} number: ", i);
                numbers.Add(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            Console.WriteLine(numbers.Max());
        }
    }
}
