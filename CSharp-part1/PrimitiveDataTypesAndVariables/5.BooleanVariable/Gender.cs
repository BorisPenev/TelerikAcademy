using System;

namespace _5.BooleanVariable
{
    class Gender
    {
        static void Main()
        {

            bool isFemale;
            string gender;

            do
            {
                Console.Write("Enter gender(male / female): ");
                gender = Console.ReadLine();
                gender.ToLowerInvariant();

                if (gender[0].Equals('m'))
                {
                    isFemale = false;
                    Console.WriteLine("Are you a female? \n{0}", isFemale);
                }
                else if (gender[0].Equals('f'))
                {
                    isFemale = true;
                    Console.WriteLine("Are you a female? \n{0}", isFemale);
                }
                else
                {
                    Console.WriteLine("Incorrect input!!!");
                }
            }
            while (!gender[0].Equals('m') && !gender[0].Equals('f'));
        }
    }
}
