using System;

namespace _5.IsThirdDigitSeven
{
    class IsThirdDigitSeven
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            string number = Console.ReadLine();
            int numberLenght = number.Length;

            if (numberLenght >= 3)
            {
                Console.WriteLine((number[numberLenght - 1 - 2]).Equals('7'));
            }
            else
            {
                Console.WriteLine("The number is too short");
            }
        }
    }
}
