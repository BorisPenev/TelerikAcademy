using System;

namespace _1.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            long number = long.Parse(Console.ReadLine());
            bool isEven = (number % 2 == 0) ? true : false;

            if (isEven)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}
