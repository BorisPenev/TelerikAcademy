using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInteger
{
    public class Bit
    {
        private int position;
        private int number;
        private int bitValue;
        private int newBitValue;
        private int mask = 1;

        public Bit()
        {
            this.GetPositionAndNumber();

            this.mask <<= position;

            this.bitValue = (number & mask) != 0 ? 1 : 0;

            Console.WriteLine("Bit value: {0}", this.bitValue);
        }

        private void GetPositionAndNumber()
        {
            Console.Write("Enter a number: ");

            this.number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter position: ");
            this.position = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (number <= 0 || position > 31)
            {
                Console.Write("Enter a positive 32bit number: ");

                this.number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Enter a valid position(0 to 31): ");
                this.position = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }

        public void IsBitOne()
        {
            bool isBitOne = this.bitValue != 0 ? true : false;

            Console.WriteLine("IsBitOne: {0}", isBitOne);
        }

        public static void SwapBitValues()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (number <= 0)
            {
                Console.Write("Enter a positive 32bit number: ");
                number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            List<int> bitPositions = new List<int>() { 3, 4, 5, 24, 25, 26 };
            List<int> bitValues = new List<int>();
            int middle = bitPositions.Count / 2;

            foreach (var position in bitPositions)
            {
                int mask = 1;
                mask <<= position;
                bitValues.Add((number & mask) != 0 ? 1 : 0);
            }

        }

        public void PrintNumberWithReplacedBit()
        {
            Console.Write("Enter new bit value (0 or 1): ");
            this.newBitValue = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (newBitValue != 0 && newBitValue != 1)
            {
                Console.Write("Enter new bit value (0 or 1): ");
                this.newBitValue = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (this.newBitValue == 1 && this.bitValue != 1)
            {
                this.number = this.number | this.mask;
                Console.WriteLine("The new number is: {0}", this.number);
            }
            else if (this.newBitValue == 0 && this.bitValue != 0)
            {
                this.number = this.number & (~this.mask);
                Console.WriteLine("The new number is: {0}", this.number);
            }
            else
            {
                Console.WriteLine("The number is still: {0}", this.number);
            }
        }
    }
}
