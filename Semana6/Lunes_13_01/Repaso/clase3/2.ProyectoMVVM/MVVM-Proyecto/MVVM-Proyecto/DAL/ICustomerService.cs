using MVVM_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Proyecto.DAL
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}
