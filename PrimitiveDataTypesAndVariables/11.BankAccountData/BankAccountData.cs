using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _11.BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            BankAccountData.GetAccountData();
        }

        public static void GetAccountData()
        {
            BankAccount account = new BankAccount()
            {
                FirstName = "EmployeeFirstName",
                MiddleName = "EmployeeMiddleName",
                LastName = "EmployeeLastName",
                BankName = "My Bank",
                Balance = 999999999M,
                IBAN = "BG12BUIN12345678901234",
                CreditCardNumbers = new List<CreditCardNumber>() 
                {
                    new CreditCardNumber(){ Number = 1},
                    new CreditCardNumber(){ Number = 2},
                    new CreditCardNumber(){ Number = 3},
                    new CreditCardNumber(){ Number = 4},
                }
            };
            
            Console.WriteLine(account);
        }
    }
}
