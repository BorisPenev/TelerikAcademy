using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main()
        {
            // 11. Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
            List<string> digitsUnderTwenty = new List<string>() 
            {
                "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                "Eleven", "Twelve", "Thirteen", "Fourtheen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" 
            };
            List<string> roundDoubleDigits = new List<string>() { "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };


            Console.Write("Enter a number [0 to 999]: ");
            int number = int.Parse(Console.ReadLine());

            while (number < 0 && number > 999)
            {
                Console.Write("Enter a number [0 to 999]: ");
                number = int.Parse(Console.ReadLine());
            }

            if (number < 20)
            {
                Console.WriteLine(DigitsUnderTwentyPronunciation(number, digitsUnderTwenty));
            }
            else if (number < 100)
            {
                Console.Write(RoundDoubleDigitsPronunciation(number / 10, roundDoubleDigits));
                Console.Write(DigitsUnderTwentyPronunciation(number % 10, digitsUnderTwenty).ToLower());
            }

            else if (number < 1000)
            {
                Console.Write(DigitsUnderTwentyPronunciation(number / 100, digitsUnderTwenty));

                if (number % 100 < 20)
                {
                    if (number % 100 != 0)
                    {
                        Console.Write(" hundred and ");
                    }
                    Console.Write(DigitsUnderTwentyPronunciation(number % 100, digitsUnderTwenty).ToLower());
                }
                else
                {
                    if (number / 10 % 10 != 0)
                    {
                        Console.Write(" hundred and ");
                    }
                    Console.Write(RoundDoubleDigitsPronunciation(number / 10 % 10, roundDoubleDigits).ToLower());

                    if (number % 10 != 0)
                    {
                        Console.Write(DigitsUnderTwentyPronunciation(number % 10, digitsUnderTwenty).ToLower());
                    }
                }

            }
        }       

        static string DigitsUnderTwentyPronunciation(int number, List<string> digits)
        {
            return digits[number];
        }

        private static string RoundDoubleDigitsPronunciation(int roundNumber, List<string> roundDoubleDigits)
        {
            return roundDoubleDigits[roundNumber - 2];
        }
    }
}
