using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.EmployeeData
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public Sex Gender { get; set; }
        public int PersonalIdNumber { get; set; }
        public int UniqueEmployeeNumber { get; set; }

        public override string ToString()
        {
            return String.Format("Employee: {0} {1}\nAge: {2}\nGender: {3}\nPersonalID: {4:0000000000}\nUniqueNumber: {5}",
                this.FirstName,
                this.LastName,
                this.Age,
                this.Gender,
                this.PersonalIdNumber,
                this.UniqueEmployeeNumber);
        }
    }
}
