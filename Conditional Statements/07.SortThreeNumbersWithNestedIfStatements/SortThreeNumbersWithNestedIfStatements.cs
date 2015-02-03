using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07.SortThreeNumbersWithNestedIfStatements
{
    class SortThreeNumbersWithNestedIfStatements
    {
        static void Main()
        {
            // 7. Write a program that enters 3 real numbers and prints them sorted in descending order.
            //   Use nested if statements.
            //   Note: Don’t use arrays and the built-in sorting functionality.
            Console.Write("Enter First Number: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter Second Number: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter Third Number: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double max = Math.Max(a, b);
            max = Math.Max(max, c);
            

            double min = Math.Min(a, b);
            min = Math.Min(min, c);

            
            if (a == max)
            {
                if (b == min)
                {
                    Console.Write("{0} {1} {2}", max, c, min);
                }
                else
                {
                    Console.Write("{0} {1} {2}", max, b, min);
                }               
            }
            else if (b == max)
	        {
                if (a == min)
                {
                    Console.Write("{0} {1} {2}", max, c, min);
                }
                else
                {
                    Console.Write("{0} {1} {2}", max, a, min);
                }  
	        }
            else if (c == max)
	        {
                if (a == min)
                {
                    Console.Write("{0} {1} {2}", max, b, min);
                }
                else
                {
                    Console.Write("{0} {1} {2}", max, a, min);
                }  
	        }
            
            //Console.Write("{0} {1} {2}",max, , min);
        }
    }
}
