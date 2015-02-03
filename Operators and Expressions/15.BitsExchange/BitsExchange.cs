using System;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            //15.Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit
            //unsigned integer.
            Console.Write("Enter an integer number = ");
            uint number = uint.Parse(Console.ReadLine());
            uint initialNumber = number;
            uint bitValue;
            uint secondBitValue;
            int firstMask;
            int secondMask;

            for (int i = 0; i < 3; i++)
            {
                firstMask = 1 << i + 3;//the mask for 3,4,5
                if (Convert.ToUInt32(number & firstMask) != 0)
                {
                    bitValue = 1;
                }
                else
                {
                    bitValue = 0;
                }

                secondMask = 1 << 24 + i;//the mask for 24,25,26
                if (Convert.ToUInt32(number & secondMask) != 0)
                {
                    secondBitValue = 1;
                }
                else
                {
                    secondBitValue = 0;
                }

                if (bitValue != secondBitValue)
                {
                    if (bitValue == 1)
                    {
                        number = Convert.ToUInt32(number & (~firstMask));
                        number = Convert.ToUInt32(number | secondMask);
                    }
                    else
                    {
                        number = Convert.ToUInt32(number | firstMask);
                        number = Convert.ToUInt32(number & (~secondMask));
                    }
                }
            }
            Console.WriteLine("\nNumber: {0}\nIn binary: {1}",
                    initialNumber, Convert.ToString(initialNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("New number: {0}\nIn binary: {1}",
                    number, Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
