using System;
namespace _12.NullValues
{
    class NullValues
    {
        static void Main()
        {
            int? someInteger = null;
            Console.WriteLine("This is the integer with Null value -> " + someInteger);
            someInteger = 5;
            Console.WriteLine("This is the integer with value 5 -> " + someInteger);

            double? someDouble = null;
            Console.WriteLine("This is the real number with Null value -> {0}", someDouble);
            someDouble = 2.5;
            Console.WriteLine("This is the real number with value 5 -> {0}", someDouble);

        }
    }
}
