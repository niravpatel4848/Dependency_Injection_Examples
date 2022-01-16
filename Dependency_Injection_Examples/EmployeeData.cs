using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Examples
{
    public class EmployeeData : IEmployeeData
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ID = 1, Name = "Neerav", Department = "IT"},
                new Employee(){ID = 2, Name = "Yana", Department = "Sales"},
                new Employee(){ID = 3, Name = "Riyana", Department = "HR"}
            };

            return employees;
        }
    }
}
