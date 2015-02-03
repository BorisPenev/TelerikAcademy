using System;

namespace _7.SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("Enter five numbers separated by a single space: ");
            string[] fiveNum = Console.ReadLine().Split(' ');
            double sum = 0;
            for (int i = 0; i < fiveNum.Length; i++)
            {
                sum += Convert.ToDouble(fiveNum[i]);
            }
            Console.WriteLine("Sum is = {0}", sum);
        }
    }
}
