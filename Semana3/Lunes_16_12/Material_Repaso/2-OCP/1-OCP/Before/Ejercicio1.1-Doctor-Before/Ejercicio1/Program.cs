using System.Numerics;
using System;
using static System.Console;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person{ FirstName = "Rodrigo", LastName="Morales", IsDoctor = true},
                new Person{ FirstName = "Miguel", LastName="Sandoval"},
                new Person{ FirstName = "Robert", LastName="Martin"}
            };

            List<Staff> staffs = new List<Staff>();
            foreach (var staff in persons)
            {
                staffs.Add(new AccountService().Create(staff));
            }

            foreach (var staff in staffs)
            {
                WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName} , {staff.Email}, Es doctor: {(staff.IsDoctor ? "Si" : "No")}");
            }
            ReadLine();
        }

    }
}