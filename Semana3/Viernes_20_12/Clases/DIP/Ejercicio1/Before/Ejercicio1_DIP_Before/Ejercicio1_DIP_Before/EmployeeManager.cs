using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_DIP_Before
{
    //Bajo nivel
    internal class EmployeeManager
    {
        private readonly List<Employee> _employees = new List<Employee>();
        public List<Employee> Employees => _employees;

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }

    }
}
