using System;

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            bool compareWithPrecision = Math.Abs(firstNumber - secondNumber) < 0.000001M;

            Console.WriteLine("The result is: {0}", compareWithPrecision);
        }
    }
}
