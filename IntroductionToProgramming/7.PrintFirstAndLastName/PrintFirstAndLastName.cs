using System;

namespace _7.PrintFirstAndLastName
{
    class PrintFirstAndLastName
    {
        static void Main()
        {
            Console.Write("Enter your First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your name is: {0} {1}", firstName, lastName);
            Console.ReadLine();
        }
    }
}
