using System;

namespace _3.VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            // Enter FE(which is 254) the result should be 254
            Console.Write("Enter a hex number: ");
            string hex = Console.ReadLine();

            int decimalNumber = Convert.ToInt32(hex, 16);
            Console.WriteLine("The decimal number is: {0}", decimalNumber);

            char ch = (char)decimalNumber;
            Console.WriteLine("The unicode character is: {0}", ch);
        }
    }
}
