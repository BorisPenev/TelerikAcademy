using System;

namespace _15.AgeAafterTenYears
{
    class AgeAafterTenYears
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your are after 10 years will be: {0}", age + 10);

        }
    }
}
