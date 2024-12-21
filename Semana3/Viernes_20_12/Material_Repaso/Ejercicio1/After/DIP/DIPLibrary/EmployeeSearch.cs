using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPLibrary
{
    public class EmployeeSearch
    {
        private readonly IEmployeeManager _employeeManager;

        public EmployeeSearch(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public int GetEmployeesByGenderAndRole(Gender gender, Role role)
        {
           return _employeeManager.GetEmployeesByGenderAndRole(gender, role);
        }

    }
}
