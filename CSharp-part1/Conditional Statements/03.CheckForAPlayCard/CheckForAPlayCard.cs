﻿using System;
using System.Collections.Generic;

namespace _03.CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main()
        {
            // Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
            // Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

            List<string> cards = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            Console.Write("Enter a card (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K or A): ");
            string cardFace = Console.ReadLine();

            if (cards.Contains(cardFace))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
