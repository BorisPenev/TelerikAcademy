using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            // 10. A beer time is after 1:00 PM and before 3:00 AM.
            // Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
            // and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
            // Note: You may need to learn how to parse dates and times.

            Console.Write("Enter a valid beer time (1:00 PM to 3:00 AM):");
            
                string time = Console.ReadLine();

                System.Threading.Thread.CurrentThread.CurrentCulture =
                    new CultureInfo("en-US");
                DateTime beerTime = DateTime.Parse(time);

                DateTime after = Convert.ToDateTime("01:00 PM");
                DateTime before = Convert.ToDateTime("03:00 AM");

                if (beerTime >= after || beerTime < before)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
        }
    }
}
