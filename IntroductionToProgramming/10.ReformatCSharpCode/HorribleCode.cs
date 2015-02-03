using System;

class HorribleCode
{
    static void Main()
    {
        Console.WriteLine("Hi, I am horribly formatted program"); 
        Console.WriteLine("Numbers and squares:"); 
            
        for (int number = 0; number < 10; number++)
        {
            Console.WriteLine(number + " --> " + number * number);
        }
    }
}