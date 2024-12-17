using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Before
{
    internal class AccountService
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
                    newStaff.Role = Role.Doctor;
                    break;

                case Role.Nurse:
                    newStaff.Email = $"{person.FirstName}.{person.LastName}@nurse.com";
                    newStaff.Role = Role.Nurse;
                    break;

                case Role.None:
                    newStaff.Email = $"{person.FirstName}.{person.LastName}@staff.com";
                    newStaff.Role = Role.None;
                    break;
            }

            return newStaff;
        }
    }
}
