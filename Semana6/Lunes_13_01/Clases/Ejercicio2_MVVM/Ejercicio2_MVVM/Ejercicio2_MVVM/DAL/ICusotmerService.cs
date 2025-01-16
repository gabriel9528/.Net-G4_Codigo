using Ejercicio2_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_MVVM.DAL
{
    public interface ICusotmerService
    {
        List<Customer> GetCustomers();
    }
}
