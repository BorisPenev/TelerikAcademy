using System;

namespace _2.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            // 2. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
            // Write a program that reads the information about a company and its manager and prints it back on the console.
            Company myCompany = new Company();
            Console.Write("Enter the company's name: ");
            myCompany.Name = Console.ReadLine();
            Console.Write("Enter the company's address: ");
            myCompany.Address = Console.ReadLine();
            Console.Write("Enter the company's phone number: ");
            myCompany.PhoneNumber = Console.ReadLine();
            Console.Write("Enter the company's fax number: ");
            myCompany.FaxNumber = Console.ReadLine();
            Console.Write("Enter the company's website: ");
            myCompany.WebSiteAddress = Console.ReadLine();          
            Console.WriteLine(new string('-', 80));

            myCompany.Manager = new Manager();
            Console.Write("Enter the manager's first name: ");
            myCompany.Manager.FirstName = Console.ReadLine();
            Console.Write("Enter the manager's last name: ");
            myCompany.Manager.LastName = Console.ReadLine();
           
            Console.Write("Enter the manager's age: ");
            myCompany.Manager.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter the manager's phone number: ");
            myCompany.Manager.PhoneNumber = Console.ReadLine();

            Console.WriteLine(new string('*', 80));
            Console.WriteLine(myCompany.ToString());
        }
    }
}
