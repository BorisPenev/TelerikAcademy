using System;

namespace _2.FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            Console.Write("Enter a floating point number with the sign: ");
            string numberInString = Console.ReadLine();
            decimal decimalNum = decimal.Parse(numberInString, System.Globalization.CultureInfo.InvariantCulture);
            double doubleNum = double.Parse(numberInString, System.Globalization.CultureInfo.InvariantCulture);
            float floatNum = float.Parse(numberInString, System.Globalization.CultureInfo.InvariantCulture);

            if (numberInString[0] == '-' || numberInString[0] == '+')
            {
                numberInString = numberInString.Remove(0, 1);
            }
            if (decimalNum - (decimal)floatNum == 0 && numberInString.Length < 9)
            {
                Console.WriteLine("decimal; double; float");
            }
            else if (decimalNum - (decimal)doubleNum == 0 && numberInString.Length < 17)
            {
                Console.WriteLine("decimal; double");
            }
            else
            {
                Console.WriteLine("decimal");
            }
            Console.ReadLine();
        }
    }
}
