using System;

namespace _4.NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers: ");
            Console.Write("First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The greater number is: {0}", Math.Max(firstNumber, secondNumber));
        }
    }
}
