using System;

namespace _8.NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            Console.Write("Enter number n = ");
            int numN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numN; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
