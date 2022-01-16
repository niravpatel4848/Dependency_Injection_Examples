using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Examples
{
    public class EmployeeLogic
    {
        /// <summary>
        /// Constructor Injection
        /// </summary>
        //private IEmployeeData _IEmployeeData;

        //public EmployeeLogic(IEmployeeData IEmployeeData)
        //{
        //    _IEmployeeData = IEmployeeData;
        //}

        //public List<Employee> GetAllEmployees()
        //{
        //    return _IEmployeeData.GetEmployees();
        //}
        ////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////
        ///Property Injection
        ////////////////////////////////////////////////////////////
        //private IEmployeeData _IEmployeeData;
        //public IEmployeeData IEmployeeDataProperty
        //{
        //    set
        //    {
        //        this._IEmployeeData = value;
        //    }
        //    get
        //    {
        //        return _IEmployeeData;
        //    }
        //}
        //public List<Employee> GetAllEmployees()
        //{
        //    return _IEmployeeData.GetEmployees();
        //}
        ///////////////////////////////////////////////////////////////////
        ///

        //////////////Method Injection//////////////////
        /////////////////////////////////////////////////

        public IEmployeeData _IEmployeeData;

        public List<Employee> GetAllEmployees(IEmployeeData IEmployeeData)
        {
            _IEmployeeData = IEmployeeData;
            return _IEmployeeData.GetEmployees();
        }
        ////////////////////////////////////////////////////
    }
}
