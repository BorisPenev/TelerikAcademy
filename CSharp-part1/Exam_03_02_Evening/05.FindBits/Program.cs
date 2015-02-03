using System;
using System.Collections.Generic;
using System.Globalization;

namespace _05.FindBits
{
    class Program
    {
        static void Main()
        {
            int mask = 1;
            int S = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            byte N = byte.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            List<int> numbers = new List<int>();
            List<byte> rightFiveBitsOfS = new List<byte>();
            int occurances = 0;

            for (int position = 0; position < 5; position++)
            {
                mask = 1 << position;
                byte bitValue = (byte)((S & mask) != 0 ? 1 : 0);
                rightFiveBitsOfS.Add(bitValue);
            }

            while (N > 0)
            {
                numbers.Add(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                N--;
            }

            foreach (int number in numbers)
            {
                for (int position = 0; position < 25; position++)
                {
                    byte counter = 0;

                    for (int i = 0; i < 5; i++)
                    {

                        mask = 1 << position + i;
                        byte bitValue = (byte)((number & mask) != 0 ? 1 : 0);
                        if (rightFiveBitsOfS[i] == bitValue)
                        {
                            counter++;
                        }
                        else
                        {

                            break;
                        }
                    }
                    if (counter == 5)
                    {
                        occurances++;
                    }
                }
            }

            Console.WriteLine(occurances);
        }
    }
}
