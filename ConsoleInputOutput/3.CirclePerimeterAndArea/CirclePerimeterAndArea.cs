using System;

namespace _3.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter the radius r = ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of the Circle is: {0: 0.00}", 2 * (Math.PI) * radius);
            Console.WriteLine("The area of the Circle is: {0: 0.00}", (Math.PI) * radius * radius);
        }
    }
}
