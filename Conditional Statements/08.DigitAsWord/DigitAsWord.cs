using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            // 8. Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
            //  Print “not a digit” in case of invalid input.
            //  Use a switch statement.

            List<string> digits = new List<string>() { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"  };

            Console.Write("Enter a digit (0 to 9): ");
            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 0: Console.WriteLine(digits[0]); break;
                case 1: Console.WriteLine(digits[1]); break;
                case 2: Console.WriteLine(digits[2]); break;
                case 3: Console.WriteLine(digits[3]); break;
                case 4: Console.WriteLine(digits[4]); break;
                case 5: Console.WriteLine(digits[5]); break;
                case 6: Console.WriteLine(digits[6]); break;
                case 7: Console.WriteLine(digits[7]); break;
                case 8: Console.WriteLine(digits[8]); break;
                case 9: Console.WriteLine(digits[9]); break;

                default: Console.WriteLine("Not a digit");
                    break;
            }
        }   
    }
}
