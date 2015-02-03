using System;

namespace _10.FibonacciSequence
{
    class FibonacciSequence
    {
        static void Main()
        {
            Console.Write("Enter the number of Fibonacci numbers you wish to see: ");
            ulong n = ulong.Parse(Console.ReadLine());
            ulong fibonacciNumber = 0;
            ulong nextNumber = 1;
            ulong sum = 0;

            for (ulong i = 0; i < n; i++)
            {
                Console.Write("{0}, ", fibonacciNumber);
                sum = fibonacciNumber + nextNumber;
                fibonacciNumber = nextNumber;
                nextNumber = sum;
            }
           
        }
    }
}
