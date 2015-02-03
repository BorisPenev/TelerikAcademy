using System;

namespace _6.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello ";
            string world = "World";
            object concatenatedString = hello + world;
            string castedString = (string)concatenatedString;
        }
    }
}
