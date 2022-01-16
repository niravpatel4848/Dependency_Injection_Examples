﻿using System;
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
        private IEmployeeData _IEmployeeData;

        public EmployeeLogic(IEmployeeData IEmployeeData)
        {
            _IEmployeeData = IEmployeeData;
        }

        public List<Employee> GetAllEmployees()
        {
            return _IEmployeeData.GetEmployees();
        }
        ////////////////////////////////////////////////////////////
    }
}