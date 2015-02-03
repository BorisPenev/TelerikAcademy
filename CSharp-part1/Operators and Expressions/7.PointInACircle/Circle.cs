using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PointInACircle
{
    public class Circle
    {
        public static void IsPointInCircle()
        {
            Console.WriteLine("Enter Point(X,Y) to see if it is inside circle K((0,0),2)");
            Console.Write("X = ");

            double pointX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nY = ");
            double pointY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int radius = 2;

            bool isInCircle = (pointX * pointX + pointY * pointY) < radius * radius;
            Console.WriteLine(isInCircle);
        }

        public static void IsPointInCircleAndOutsideOfRectangle()
        {
            Console.WriteLine("Enter Point(X,Y) to see if it is inside circle K((1,1),1.5) and outside of rectangle ((1,-1),(6,2))");
            Console.Write("X = ");
            double pointX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nY = ");
            double pointY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double radius = 1.5;

            bool isInCircle = ((pointX -1)*(pointX - 1) + (pointY -1)* (pointY - 1)) <= radius * radius;
            
            if (isInCircle)
            {
                if ((pointX > radius - 1 && pointX < radius + 1) && pointY > 1)
                {
                    Console.WriteLine("The point ({0},{1}) is in the circle and outside of the rectangle", pointX, pointY);
                }
                else
                {
                    Console.WriteLine("The point ({0},{1}) is in the circle and in the rectangle", pointX, pointY);
                }
            }
            else
            {
                Console.WriteLine("The point ({0},{1}) is outside of the circle", pointX, pointY);
            }
        }
    }
}
