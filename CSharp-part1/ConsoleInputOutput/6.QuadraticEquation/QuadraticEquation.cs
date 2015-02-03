using System;

namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter the coefficients(a,b,c) in ax^2 + bx + c = 0");
            Console.Write("Enter coefficient a = ");
            double coefficientA = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient b = ");
            double coefficientB = double.Parse(Console.ReadLine()); 
            Console.Write("Enter coefficient c = ");
            double coefficientC = double.Parse(Console.ReadLine()); 

            double discriminant = coefficientB * coefficientB - 4 * coefficientA * coefficientC;
            double rootOne;
            double rootTwo;

            if (coefficientA == 0)
            {
                rootOne = (-coefficientC) / coefficientB;
                Console.WriteLine("There is only one root: {0}", rootOne);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("There is no real root");
            }
            else if (discriminant == 0)
            {
                rootOne = (-coefficientB) / (2 * coefficientA);
                Console.WriteLine("There is only one root: {0}", rootOne);
            }
            else
            {
                rootOne = ((-coefficientB) + Math.Sqrt(discriminant)) / (2 * coefficientA);
                rootTwo = ((-coefficientB) - Math.Sqrt(discriminant)) / (2 * coefficientA);
                Console.WriteLine("Root One is: {0}", rootOne);
                Console.WriteLine("Root One is: {0}", rootTwo);
            }
        }
    }
}
