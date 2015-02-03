using System;

namespace _4.UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main()
        {
            string hex = "0x2A";

            int decimalNumber = Convert.ToInt32(hex, 16);
            Console.WriteLine("The decimal number is: {0}", decimalNumber);

            char ch = (char)decimalNumber;
            Console.WriteLine("The unicode character is: {0}", ch);
        }
    }
}
