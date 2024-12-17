using System.Numerics;
using System;
using static System.Console;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> persons = new List<IPerson>()
            {
                new Person{ FirstName = "Rodrigo", LastName="Morales"},
                new Doctor{ FirstName = "Miguel", LastName="Sandoval"},
                new Nurse{ FirstName = "Robert", LastName="Martin"}
            };

            List<Staff> staffs = new List<Staff>();
            foreach (var item in persons)
            {
                staffs.Add(item.IAccountService.Create(item));
            }

            foreach (var staff in staffs)
            {
                WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName} , {staff.Email}");
            }
            ReadLine();
        }

    }
}