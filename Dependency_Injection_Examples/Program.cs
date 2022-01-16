using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            ///for constructor injection///////////////
            ///EmployeeLogic employeeLogic = new EmployeeLogic(new EmployeeData());
            ///////////////////////////////////////////////////////////////////
            ///
            ///for property injection///////////////
            //EmployeeLogic employeeLogic = new EmployeeLogic();
            //employeeLogic.IEmployeeDataProperty = new EmployeeData();
            ///////////////////////////////////////////////////////////////////
            ///
            ////for method injection///////////
            EmployeeLogic employeeLogic = new EmployeeLogic();
            List<Employee> EmployeeList = employeeLogic.GetAllEmployees( new EmployeeData());

            //List<Employee> EmployeeList = employeeLogic.GetAllEmployees();

            foreach (Employee emp in EmployeeList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }

            Console.ReadKey();
        }
    }
}
