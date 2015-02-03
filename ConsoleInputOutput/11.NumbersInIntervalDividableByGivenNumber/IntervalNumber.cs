using System;
using System.Collections.Generic;
namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class IntervalNumber
    {
        static void Main()
        {
            Console.Write("Enter the start number: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the end number: ");
            int endNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            int result = 0;
            List<int> printNumbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % divisor == 0)
                {
                    printNumbers.Add(i);
                    result++;
                }
            }
            Console.WriteLine("P = {0}", result);
            Console.WriteLine("The numbers divided by {0} are: ", divisor);
            if (printNumbers.Count > 0)
            {
                foreach (int number in printNumbers)
                {
                    Console.Write("{0}, ", number);
                }
            }
            else
            {
                Console.Write(0); 
            }
        }
    }
}
