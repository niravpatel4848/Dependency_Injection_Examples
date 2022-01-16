using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Examples
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees();
    }
}
