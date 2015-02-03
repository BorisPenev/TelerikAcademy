using System;

namespace _16.BitsExchangeAdvanced
{
    class BitsExchangeAdvanced
    {
        static void Main()
        {
            /*
              16. Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} 
                  of given 32-bit unsigned integer.
             */
            Console.Write("Enter an integer number = ");
            uint number = uint.Parse(Console.ReadLine());
            uint initialNumber = number;
            Console.Write("How many bits would you like to exchange: ");
            int numberOfExchaningBits = int.Parse(Console.ReadLine());
            int bit;
            int exchangedBit;
            uint bitValue;
            uint secondBitValue;
            int firstMask;
            int secondMask;
            
            while (numberOfExchaningBits != 0)
	        {
                Console.Write("Enter bit: ");
                bit = int.Parse(Console.ReadLine());
                Console.Write("Enter to which bit to be exchanged to: ");
                exchangedBit = int.Parse(Console.ReadLine());
	         
                for (int i = bit, j = exchangedBit; ((i < bit + 1) && (j <exchangedBit + 1)); i++, j++)
                {                
                    firstMask = 1 << i;//the mask for the bit
                    if (Convert.ToUInt32(number & firstMask) != 0)
                    {
                        bitValue = 1;
                    }
                    else
                    {
                        bitValue = 0;
                    }
              
                    secondMask = 1 << j;//the mask for the exchanging bit
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
                numberOfExchaningBits--;
                Console.WriteLine("\nNumber: {0}\nIn binary: {1}",
                        initialNumber, Convert.ToString(initialNumber, 2).PadLeft(32, '0'));
                Console.WriteLine("New number: {0}\nIn binary: {1}",
                        number, Convert.ToString(number, 2).PadLeft(32, '0'));
            }
        }
    }
}
