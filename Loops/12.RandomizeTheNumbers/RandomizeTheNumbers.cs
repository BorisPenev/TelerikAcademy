using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.RandomizeTheNumbers
{
    class RandomizeTheNumbers
    {
        static void Main()
        {
            // 12. Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
           // Random rand = new Random();

            Console.Write("Enter an integer number N: ");
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            IList<int> numbers = new List<int>();
            
            for (int i = 1; i <= N; i++)
            {
                numbers.Add(i);
            }

            IList<int> shuffledList = RandomizeTheNumbers.Shuffle<int>(numbers);
            foreach (int number in shuffledList)
            {
                Console.Write("{0} ", number);   
            }
        }

        // source of the shuffle logic: http://stackoverflow.com/questions/20075252/how-can-i-implement-a-c-sharp-shuffle-algorithm-in-an-extension-method
        public static IList<T> Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }
    }
}
