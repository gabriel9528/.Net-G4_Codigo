using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class AccountNurse : IAccountService
    {
        public Staff Create(IPerson IPerson)
        {
            Staff newStaff = new Staff();
            newStaff.FirstName = IPerson.FirstName;
            newStaff.LastName = IPerson.LastName;
            newStaff.Email = $"{IPerson.FirstName}.{IPerson.LastName}@nurse.com";

            return newStaff;
        }
    }
}
