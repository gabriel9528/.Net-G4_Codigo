using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Doctor : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService IAccountService { get; set; } = new AccountDoctor();
    }
}
