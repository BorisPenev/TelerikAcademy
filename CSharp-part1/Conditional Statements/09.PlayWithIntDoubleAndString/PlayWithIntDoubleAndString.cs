using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            // 9. Write a program that, depending on the user’s choice, inputs an int, double or string variable.
            //    If the variable is int or double, the program increases it by one.
            //    If the variable is a string, the program appends * at the end.
            //    Print the result at the console. Use switch statement.

            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1: 
                    {
                        Console.Write("Please enter an integer: ");
                        int userInteger = int.Parse(Console.ReadLine());
                        Console.WriteLine(userInteger + 1);
                    }
                    break;
                case 2:
                    {
                        Console.Write("Please enter a double: ");
                        double userDouble = double.Parse(Console.ReadLine());
                        Console.WriteLine(userDouble + 1);
                    }
                    break;
                case 3:
                    {
                        Console.Write("Please enter a string: ");
                        string userString = Console.ReadLine();
                        Console.WriteLine(userString + "*");
                    }
                    break;
                default:
                    Console.WriteLine("Not a valid input type! (Should be 1,2 or 3)");
                    break;
            }
        }
    }
}
