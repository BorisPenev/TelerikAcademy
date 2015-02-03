using System;

namespace _3.Division
{
    class Division
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            long number = long.Parse(Console.ReadLine());
            bool isEven = (number % 35 == 0) ? true : false;

            if (isEven)
            {
                Console.WriteLine("The number does divide WITHOUT remainder");
            }
            else
            {
                Console.WriteLine("The number does divide WITH remainder");
            }
        }
    }
}
