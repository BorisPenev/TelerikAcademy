using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Four_DigitNumber
{
    public class OperationsOnFourDigitNumber
    {
        private int fourDigitNumber;
        public int FourDigitNumber
        {
            get
            {
                return this.fourDigitNumber;
            }
            private set
            {
                if (this.fourDigitNumber != value)
                {
                    this.fourDigitNumber = value;
                }
            }
        }

        public OperationsOnFourDigitNumber()
        {
            this.fourDigitNumber = this.GetNumber();
            this.SumOfTheNumbers(this.FourDigitNumber);
            this.DisplayDigitsInReverse(this.FourDigitNumber);
            this.PutLastDigitToFirstPosition(this.FourDigitNumber);
            this.SwapSecondAndThirdDigits(this.FourDigitNumber);
        }

        private int GetNumber()
        {
            Console.Write("Enter a four digit number: ");

            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number.ToString().Length > 4 || number.ToString().Length < 4)
            {
                Console.WriteLine("The entered number must be four digits!!!");
                return 0;
            }

            return number;
        }

        private void PrintNumber(object number, string message)
        {
            Console.WriteLine(message, number);
        }

        private void SumOfTheNumbers(int number)
        {
            int sum = 0;
            string convrtedNUmber = number.ToString();
            foreach (var digit in convrtedNUmber)
            {
                sum += int.Parse(digit.ToString());
            }
            string message = "Sum of the digits: {0}";
            this.PrintNumber(sum, message);
        }

        private void DisplayDigitsInReverse(int number)
        {
            string digitsInReverce = string.Empty;

            string convrtedNumber = number.ToString();

            for (int i = convrtedNumber.Length - 1; i >= 0; i--)
            {
                digitsInReverce += convrtedNumber[i];
            }

            string message = "Digits in reverse: {0}";
            this.PrintNumber(digitsInReverce, message);
        }

        private void PutLastDigitToFirstPosition(int number)
        {
            string digitsInReverce = string.Empty;
            string convrtedNumber = number.ToString();
            string lastNumber = convrtedNumber.Last().ToString();
            string result = lastNumber + convrtedNumber.Remove(convrtedNumber.Length - 1);

            string message = "Put last digit first: {0}";
            this.PrintNumber(result, message);
        }

        private void SwapSecondAndThirdDigits(int number)
        {
            string swapedDigits = string.Empty;
            string convertedNumber = number.ToString();

            string secondDigit = convertedNumber[1].ToString();
            string thirdDigit = convertedNumber[2].ToString();

            swapedDigits = convertedNumber.FirstOrDefault() + thirdDigit + secondDigit + convertedNumber.LastOrDefault();

            string message = "Swaped second and third digits: {0}";
            this.PrintNumber(swapedDigits, message);
        }
    }
}
