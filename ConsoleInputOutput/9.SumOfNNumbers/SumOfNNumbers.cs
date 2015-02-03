using System;

namespace _9.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number N(which is the number of other numbers you'd have to enter to add to the Sum): ");
            int initialNumber = int.Parse(Console.ReadLine());
            int number = 0;
            int sum = 0;

            for (int i = 0; i < initialNumber; i++)
            {
                Console.Write("{0}.N = ", i + 1);
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("The sum of all those numbers is: {0}", sum);
        }
    }
}
