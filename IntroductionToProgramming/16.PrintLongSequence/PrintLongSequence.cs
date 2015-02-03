using System;

namespace _16.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int count = 0;
            for (int index = 2; index <= 1001; index++)
            {
                if ((index % 2) == 0)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine((-1) * index);
                }
                count++;
            }
            Console.WriteLine("Count: {0}", count);
            Console.ReadLine();
        }
    }
}
