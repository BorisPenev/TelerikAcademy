using System;

namespace _8.IsoscelesTriangle
{
    class Program
    {
        static void Main()
        {
            char symbol = '\u00A9';
            int count = 1;
            int sizeOfSides = int.Parse(Console.ReadLine());

            //while (count <= sizeOfSides)
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.Write(symbol);
            //    }
            //    Console.WriteLine();
            //    count++;
            //}
            for (int i = 1; i <= sizeOfSides; i++)
            {
                string spaces = new string(' ', sizeOfSides - i);
                string symbols = new string(symbol, 2 * i - 1);
                Console.Write(spaces);
                Console.WriteLine(symbols);
            }
        }
    }
}
