using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintCompanyInformation
{
    public class Company
    {// 2. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WebSiteAddress { get; set; }
        public Manager Manager { get; set; }

        public override string ToString()
        {
            string printCompanyData = string.Format(@"Company: {0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \n{5}", 
                Name,
                Address, 
                PhoneNumber, 
                FaxNumber, 
                WebSiteAddress,
                Manager.ToString());
            return printCompanyData;
        }
    }
}
