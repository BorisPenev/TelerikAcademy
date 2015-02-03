using System;
using System.Globalization;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            // 4. Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
            // Use a sequence of if operators.

            Console.Write("Enter First Number: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter Second Number: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter Third Number: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if ((a < 0 && b < 0 && c < 0) || (a < 0 && b >= 0 && c >= 0)
                || (a >= 0 && b < 0 && c >= 0) || (a >= 0 && b >= 0 && c < 0))
            {
                Console.WriteLine("-");
            }
            else 
            {
                Console.WriteLine("+");
            }
        }
    }
}
