using System;

namespace _11.ExtractThirdBit
{
    class ExtractThirdBit
    {
        static void Main()
        {
            // 8 --> 1000; 7 --> 0111
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int thirdBit = (number >> 3) & 1;
            Console.WriteLine(thirdBit);
        }
    }
}
