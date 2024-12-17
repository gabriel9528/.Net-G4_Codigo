using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Before.AccountImplementation
{
    internal class AccountStaff : IAccountService
    {
        public Staff_1 Create(IPerson IPerson)
        {
            Staff_1 newStaff = new Staff_1();
            newStaff.FirstName = IPerson.FirstName;
            newStaff.LastName = IPerson.LastName;
            newStaff.Email = $"{IPerson.FirstName}.{IPerson.LastName}@staff.com";

            return newStaff;

        }
    }
}
