using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Before
{
    internal interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        IAccountService IAccountService { get; set; }
    }
}
