using System;
using System.Collections.ObjectModel;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            EmployeeData.GetEmployees();
        }

        public static void GetEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

            for (int index = 0; index < 3; index++)
            {
                employees.Add(new Employee()
                {
                    FirstName = "EmployeeFN " + index,
                    LastName = "EmployeeLN " + index,
                    Age = (byte)(15 * index),
                    Gender = (index % 2 == 0) ? Sex.Male : Sex.Female,
                    PersonalIdNumber = index,
                    UniqueEmployeeNumber = 27560000 + index
                });
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }
        }
    }
}
