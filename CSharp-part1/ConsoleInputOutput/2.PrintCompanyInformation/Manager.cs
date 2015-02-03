using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintCompanyInformation
{
    public class Manager
    {
        //The manager has first name, last name, age and a phone number.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            string printManagerData = string.Format("Manager: {0} {1} (age: {2}, tel. {3})", FirstName, LastName, Age, PhoneNumber);
            return printManagerData;
        }
    }
}
