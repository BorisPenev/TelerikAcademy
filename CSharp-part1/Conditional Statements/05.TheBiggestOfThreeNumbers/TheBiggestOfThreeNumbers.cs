using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main()
        {
            // 5. Write a program that finds the biggest of three numbers.
            List<int> numbers = new List<int>();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter {0} number: ", i);
                numbers.Add(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            Console.WriteLine(numbers.Max());
        }        
    }
}
