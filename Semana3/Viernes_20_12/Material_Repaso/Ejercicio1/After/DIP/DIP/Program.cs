﻿using DIPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Rodrigo", Gender = Gender.Male, Role = Role.Developer },
                new Employee { Name = "Robert", Gender = Gender.Male, Role = Role.Executive },
                new Employee { Name = "Martin", Gender = Gender.Male, Role = Role.Executive },
                new Employee { Name = "Vanessa", Gender = Gender.Female, Role = Role.Executive }
            };
            IEmployeeManager employeManager = new EmployeeManager();

            foreach (var employee in employees)
               employeManager.Save(employee);

           var search =  new EmployeeSearch(employeManager);

           Console.WriteLine($" Cantidad de Empleados Ejecutivos y de genero Masculino:  {search.GetEmployeesByGenderAndRole(Gender.Male, Role.Executive)}");
           Console.ReadLine();

        }

    }
}
