using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_DIP_After
{
    internal interface IEmployeeManager
    {
        void Save(Employee employee);
        int GetEmployeeByGenderAndRole(Gender gender, Role role);
    }
}
