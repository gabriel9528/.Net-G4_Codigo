using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPLibrary
{
    public class EmployeeManager 
    {
        //Usar readonly garantiza que el campo _employees no pueda ser reasignado después de su inicialización,
        //mientras permite modificar su contenido (agregar o eliminar empleados) solo internamente.
        private readonly List<Employee> _employees = new List<Employee>();
        public List<Employee> Employees => _employees;

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }

    }
}
