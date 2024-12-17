using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class AccountService
    {
        public Staff Create(Person person)
        {
            Staff newStaff = new Staff();
            newStaff.FirstName = person.FirstName;
            newStaff.LastName = person.LastName;
            newStaff.Email = $"{person.FirstName}.{person.LastName}@staff.com";

            return newStaff;
        }
    }
}
