using System;
using System.Globalization;

namespace _8.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Enter a number (1 < N < 100)");
            Console.WriteLine(PrimeNumberCheck.isPrime(long.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)));

        }

        public static bool isPrime(long n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 5; i * i <= n; i += 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
