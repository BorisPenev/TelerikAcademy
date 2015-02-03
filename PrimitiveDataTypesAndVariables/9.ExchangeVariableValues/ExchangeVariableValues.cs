using System;

namespace _9.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before swap of the values: \nA = {0}\nB = {1}", a, b);

            a = a + b;
            b = a - b;
            a = a - b;
            
            Console.WriteLine("\n\nAfter swap of the values: \nA = {0}\nB = {1}", a, b);
        }
    }
}
