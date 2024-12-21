using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPLibrary
{
    public class EmployeeSearch
    {
        private readonly EmployeeManager _employeeManager;

        public EmployeeSearch(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public int GetMaleExecutives()
        {
            return _employeeManager
                .Employees
                .Where(x => x.Gender == Gender.Male && x.Role == Role.Executive).ToList().Count();
        }

    }
}
