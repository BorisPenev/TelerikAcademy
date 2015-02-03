using System;
using System.Globalization;

namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            // 11.Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
            
            Random rand = new Random();

            Console.Write("Enter an integer number N: ");
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter an integer number Min: ");
            int min = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter an integer number Max: ");
            int max = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (min != max)
            {
                for (int count = 0; count < N; count++)
                {
                    Console.WriteLine(rand.Next(min, max));                    
                }
            }
            else
            {
                Console.WriteLine("Invalid input numbers. You should have enter (min != max)");
                return;
            }
        }
    }
}
