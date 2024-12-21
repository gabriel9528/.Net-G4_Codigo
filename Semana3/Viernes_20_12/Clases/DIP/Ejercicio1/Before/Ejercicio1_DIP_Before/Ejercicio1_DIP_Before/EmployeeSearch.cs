using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_DIP_Before
{
    //Alto nivel
    internal class EmployeeSearch
    {
        private readonly EmployeeManager _employeeManager;

        public EmployeeSearch(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public int GetMaleExecutive()
        {
            return _employeeManager
                .Employees
                .Where(x => x.Gender == Gender.Male && x.Role == Role.Executive).ToList().Count();
        }
        
    }
}
