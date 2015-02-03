using System;
using System.Globalization;

namespace _9.Trapezoids
{
    class Trapezoid
    {
        static void Main()
        {
            Trapezoid.FindArea();
        }

        public static void FindArea()
        {
            Console.Write("Enter a = ");
            double baseA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter b = ");
            double baseB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter H = ");
            double Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(((baseA + baseB) * Height) / 2);
            Console.ReadLine();
        }
    }
}
