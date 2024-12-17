using Ejercicio1Nurse;
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
            switch (person.Role)
            {
                case Role.Doctor:
                    newStaff.Email = $"{person.FirstName}.{person.LastName}@doctor.com";
                    break;
                case Role.Nurse:
                    newStaff.Email = $"{person.FirstName}.{person.LastName}@nurse.com";
                    break;
                case Role.None:
                    newStaff.Email = $"{person.FirstName}.{person.LastName}@staff.com";
                    break;
            }
            newStaff.Role = person.Role;

            return newStaff;
        }
    }
}
