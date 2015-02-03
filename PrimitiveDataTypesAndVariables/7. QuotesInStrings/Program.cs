using System;

namespace _7.QuotesInStrings
{
    class Program
    {
        static void Main()
        {
            string textWithoutQuotes = "The use of quotations causes difficulties.";
            Console.WriteLine(textWithoutQuotes);
            string textWithQuotes = "The \" use \" of quotations causes difficulties.";
            Console.WriteLine(textWithQuotes);
        }
    }
}
