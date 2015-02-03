using System;

namespace _4.Rectangles
{
    class Rectangle
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            double baseA = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double baseB = double.Parse(Console.ReadLine());

            Rectangle.FindPerimeter(baseA, baseB);
            Console.WriteLine("Area: {0}", baseA * baseB);
        }

        public static void FindPerimeter(double baseA, double baseB)
        {
            Console.WriteLine("Perimeter: {0}", (baseA + baseB) * 2);
            Console.ReadLine();
        }
    }
}
