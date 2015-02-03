using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            // 10. You are given n integers (given in a single line, separated by a space).
            // Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            // Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

            
            int oddNumberProduct = 1;
            int evenNumberProduct = 1;
            string input;

            Console.Write("Enter a sequense of numbers eparated by a single space: ");
            input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            foreach (string number in numbers)
            {
                int convertedNumber = int.Parse(number);
                if (convertedNumber % 2 == 0)
                {
                    evenNumberProduct *= convertedNumber;
                }
                else
                {
                    oddNumberProduct *= convertedNumber;
                }
            }

            Console.WriteLine("Odd product: {0} \nEven product: {1}", oddNumberProduct, evenNumberProduct);
            Console.WriteLine("Are they equal: {0}", (oddNumberProduct == evenNumberProduct)? "Yes": "No");
        }
    }
}
