using System;
using System.Collections.Generic;
using System.Text;

namespace DIPLibrary
{
    public interface IEmployeeManager
    {
        void Save(Employee employee);
        int GetEmployeesByGenderAndRole(Gender gender, Role role);
    }
}
