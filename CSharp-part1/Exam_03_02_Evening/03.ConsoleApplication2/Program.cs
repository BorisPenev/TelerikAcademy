using System;
using System.Collections.Generic;
using System.Numerics;

namespace _03.ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;

            List<ulong> inputNumbers = new List<ulong>();
            List<BigInteger> productOfEvenNumbers = new List<BigInteger>();
            List<BigInteger> otherNumbers = new List<BigInteger>();

            //int counter = 0;
            while (input != "END")
            {
                input = Console.ReadLine();
                ulong number;
                bool isNumber = ulong.TryParse(input, out number);

                if (isNumber)
                {
                    inputNumbers.Add(number);
                }
            }

            int inputNumbersCount = inputNumbers.Count;

            if (inputNumbersCount <= 10)
            {

                for (int i = 0; i < inputNumbersCount; i++)
                {
                    if (i % 2 == 0)
                    {
                        productOfEvenNumbers.Add(CalculateProduct(inputNumbers[i]));
                    }
                }

                ulong product = 1;
                foreach (ulong number in productOfEvenNumbers)
                {
                    product *= number;
                }
                Console.WriteLine(product);

            }
            else
            {
                for (int i = 0; i < inputNumbersCount; i++)
                {
                    if (i % 2 == 0 && i <= 9)
                    {
                        productOfEvenNumbers.Add(CalculateProduct(inputNumbers[i]));
                    }
                    else
                    {
                        if (i % 2 == 0 && i > 9)
                        {
                            otherNumbers.Add(CalculateProduct(inputNumbers[i]));
                        }
                    }
                }

                BigInteger product = 1;
                foreach (BigInteger number in productOfEvenNumbers)
                {
                    product *= number;
                }
                Console.WriteLine(product);

                product = 1;
                foreach (BigInteger number in otherNumbers)
                {
                    product *= number;
                }
                Console.WriteLine(product);
            }

        }

        private static BigInteger CalculateProduct(ulong number)
        {
            BigInteger product = 1L;

            string digits = number.ToString();

            foreach (char digit in digits)
            {
                switch (digit)
                {
                    case '1': product *= 1; break;
                    case '2': product *= 2; break;
                    case '3': product *= 3; break;
                    case '4': product *= 4; break;
                    case '5': product *= 5; break;
                    case '6': product *= 6; break;
                    case '7': product *= 7; break;
                    case '8': product *= 8; break;
                    case '9': product *= 9; break;

                    default: product *= 1;
                        break;
                }
            }


            return product;
        }

    }
}
