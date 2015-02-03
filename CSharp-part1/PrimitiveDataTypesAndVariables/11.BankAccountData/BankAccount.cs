using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    public class BankAccount
    {
        private string iban;

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Holder
        {
            get { return string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName); ; }
        }

        public decimal Balance { get; set; }
        public string BankName { get; set; }
        public string IBAN 
        {
            get 
            { 
                return string.Format("{0:0000000000000000000000}", this.iban);
            }
            set
            {
                if (this.iban != value)
                {
                    this.iban = value;
                }
            }
        }
        public List<CreditCardNumber> CreditCardNumbers { get; set; }

        public BankAccount()
        {
            this.CreditCardNumbers = new List<CreditCardNumber>();
        }

        public override string ToString()
        {
            string formattedString = string.Format("Bank Name:{0}\nAccount Holder: {1}\nBalance: {2}\nIBAN: {3}",
                this.BankName,                
                this.Holder,
                this.Balance,
                this.IBAN);

            foreach (CreditCardNumber creditCard in this.CreditCardNumbers)
            {
                formattedString += string.Format("\n{0}", creditCard.ToString());
            }

            return formattedString;
        }
    }
}
