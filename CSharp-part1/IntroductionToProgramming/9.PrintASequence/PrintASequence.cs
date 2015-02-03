using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PrintASequence
{
    class PrintASequence
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int index = 2; index <= 11; index++)
            {
                if ((index %2) == 0)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine((-1)*index);
                }
                count++;
            }
            Console.WriteLine("Count: {0}", count);
            Console.ReadLine();
        }
    }
}
