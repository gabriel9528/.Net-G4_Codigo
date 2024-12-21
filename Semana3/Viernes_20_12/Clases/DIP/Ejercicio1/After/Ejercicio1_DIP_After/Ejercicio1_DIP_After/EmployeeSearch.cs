using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_DIP_After
{
    internal class EmployeeSearch
    {
        private readonly IEmployeeManager _employeeManager;

        public EmployeeSearch(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public int GetEmployeeByGenderAndRole(Gender gender, Role role)
        {
            return _employeeManager.GetEmployeeByGenderAndRole(gender, role);
        }

    }
}
