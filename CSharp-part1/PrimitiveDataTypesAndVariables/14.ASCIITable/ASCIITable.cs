using System;

namespace _14.ASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            Console.WriteLine("Number, Hex, Symbol");
            for (int i = 0; i < 255; i++)
            { 
               
                Console.Write("{0,-7} {1,-7:X} {2}",i, i, (char)i);
                Console.WriteLine();
               
            }
        }
    }
}
