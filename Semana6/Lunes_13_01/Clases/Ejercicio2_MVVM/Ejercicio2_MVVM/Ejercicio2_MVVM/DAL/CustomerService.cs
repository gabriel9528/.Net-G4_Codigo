using Ejercicio2_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_MVVM.DAL
{
    public class CustomerService : ICusotmerService
    {
        public List<Customer> GetCustomers()
        {
            var listCustomers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Gabriel", SecondName = "Antonio", LastName = "Flores", SecondLastName = "Martinez", IsEnabled = true, DateLogin = DateTime.Now.AddDays(-5) },
                new Customer { Id = 2, FirstName = "Jane", SecondName = "Elena", LastName = "Bellota", SecondLastName = "Perez", IsEnabled = false, DateLogin = DateTime.Now.AddDays(-15) },
                new Customer { Id = 3, FirstName = "John", SecondName = "Paul", LastName = "Garcia", SecondLastName = "Gomez", IsEnabled = true, DateLogin = DateTime.Now.AddDays(-30) },
                new Customer { Id = 4, FirstName = "Pedro", SecondName = "Luis", LastName = "Smith", SecondLastName = "Johnson", IsEnabled = true, DateLogin = DateTime.Now.AddDays(-1) },
                new Customer { Id = 5, FirstName = "Maria", SecondName = "Teresa", LastName = "Lopez", SecondLastName = "Hernandez", IsEnabled = false, DateLogin = DateTime.Now.AddDays(-10) },
                new Customer { Id = 6, FirstName = "Carlos", SecondName = "Miguel", LastName = "Sanchez", SecondLastName = "Ramirez", IsEnabled = true, DateLogin = DateTime.Now.AddDays(-3) },
                new Customer { Id = 7, FirstName = "Laura", SecondName = "Isabel", LastName = "Gonzalez", SecondLastName = "Torres", IsEnabled = true, DateLogin = DateTime.Now.AddDays(-7) },
                new Customer { Id = 8, FirstName = "Luis", SecondName = "Alberto", LastName = "Martinez", SecondLastName = "Diaz", IsEnabled = false, DateLogin = DateTime.Now.AddDays(-20) },
                new Customer { Id = 9, FirstName = "Ana", SecondName = "Victoria", LastName = "Rodriguez", SecondLastName = "Ruiz", IsEnabled = true, DateLogin = DateTime.Now.AddDays(-2) },
                new Customer { Id = 10, FirstName = "Miguel", SecondName = "Angel", LastName = "Perez", SecondLastName = "Fernandez", IsEnabled = true, DateLogin = DateTime.Now.AddDays(-8) }
            };

            return listCustomers;
        }
    }
}
