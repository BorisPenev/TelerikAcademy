using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Enter the weight of a human on Earth: ");
            double humanWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("The human will wight on the Moon: {0}", humanWeight * 0.17);
        }
    }
}
