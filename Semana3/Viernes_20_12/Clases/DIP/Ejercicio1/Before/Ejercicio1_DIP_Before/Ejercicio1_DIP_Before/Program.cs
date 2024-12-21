
using Ejercicio1_DIP_Before;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){Name = "Jose", Gender = Gender.Male, Role = Role.Executive },
            new Employee(){Name = "Andres", Gender = Gender.Male, Role = Role.Executive },
            new Employee(){Name = "Maria", Gender = Gender.Female, Role = Role.Executive },
            new Employee(){Name = "Ricardo", Gender = Gender.Male, Role = Role.Executive },
            new Employee(){Name = "Vanessa", Gender = Gender.Male, Role = Role.Manager },
        };

        var employeeManager = new EmployeeManager();

        foreach (var iterador in employees)
        {
            employeeManager.Save(iterador);
        }

        var search = new EmployeeSearch(employeeManager);

        Console.WriteLine($"La cantidad de empleados Executive y Male son: {search.GetMaleExecutive()}");
        Console.ReadLine();

    }
}