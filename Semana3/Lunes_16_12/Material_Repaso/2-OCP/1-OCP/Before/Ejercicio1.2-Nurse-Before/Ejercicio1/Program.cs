using System.Numerics;
using System;
using static System.Console;
using Ejercicio1Nurse;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person{ FirstName = "Rodrigo", LastName="Morales", Role = Role.Doctor },
                new Person{ FirstName = "Miguel", LastName="Sandoval", Role = Role.Nurse },
                new Person{ FirstName = "Robert", LastName="Martin"}
            };

            List<Staff> staffs = new List<Staff>();
            foreach (var staff in persons)
            {
                staffs.Add(new AccountService().Create(staff));
            }

            foreach (var staff in staffs)
            {
                WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName} , {staff.Email}, Es doctor: {(staff.Role == Role.Doctor ? "Si" : "No")}, Es enfermera: {(staff.Role == Role.Nurse ? "Si" : "No")}");
            }
            ReadLine();
        }

    }
}