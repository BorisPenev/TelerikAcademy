using System;
using System.Collections.Generic;

namespace _04.PrintADeckOfFiftyTwoCards
{
    class PrintADeckOfFiftyTwoCards
    {
        static void Main()
        {
            // 4. Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
            // The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamoLisnds).
            // The card faces should start from 2 to A.
            // Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
            // Note: You may use the suit symbols instead of text.

            List<string> cards = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (string card in cards)
            {
                Console.WriteLine("{0,2}{1}, {0,2}{2}, {0,2}{3}, {0,2}{4}", card, (char)5, (char)4, (char)3, (char)6);
            }
        }
    }
}
