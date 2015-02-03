using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    public class CreditCardNumber
    {
        public int Number { get; set; }

        public override string ToString()
        {
            string formattedString = string.Format("CreditCard Number: {0:000000000000}", this.Number);
            return formattedString;
        }
    }
}
