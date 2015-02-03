using System;
using System.Collections.Generic;
using System.Globalization;

namespace _02.SymbolToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            string input = Console.ReadLine();

            List<int> encodedValues = new List<int>();

            int counter = 0;
            while (input.Length > 0 )
            {
                if (input[counter] != '@')
                {                   

                    if (IsLetter(input[counter].ToString()))
                    {
                        encodedValues.Add((int)input[counter] * secret + 1000);
                    }
                    else if (IsNumber(input[counter]))
                    {

                        encodedValues.Add((int)input[counter] + secret + 500);
                    }
                    else
                    {

                        encodedValues.Add((int)input[counter] - secret);
                    }

                    counter++;
                }
                else
                {
                    break;
                }
                
            }

            for (int i = 0; i < counter; i++)
            {
                if (i % 2 == 0)
                {                    
                    double value = encodedValues[i];
                    value /= 100.0;

                    Console.WriteLine("{0:F2}", value);
                }
                else
                {                    
                    Console.WriteLine(encodedValues[i] *= 100);
                }
            }
        }

        private static bool IsNumber(char inputNumber)
        {
            bool isNumber = false;

            List<char> numbers = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (char number in numbers)
            {
                if (inputNumber == number)
                {
                    isNumber = true;
                    break;
                }
            }

            return isNumber;
        }

        private static bool IsLetter(string inputLetter)
        {
            bool isLetter = false;

            List<char> letters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (char letter in letters)
            {
                if (inputLetter.ToLower() == letter.ToString())
                {
                    isLetter = true;
                    break;
                }
            }

            return isLetter;
        }
    }
}
