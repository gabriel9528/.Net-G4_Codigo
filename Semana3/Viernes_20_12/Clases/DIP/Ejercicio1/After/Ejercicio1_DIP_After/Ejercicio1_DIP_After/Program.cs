
using Ejercicio1_DIP_After;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){ Name = "Jose", Role = Role.Executive, Gender = Gender.Male },
            new Employee(){ Name = "Maria", Role = Role.Manager, Gender = Gender.Female },
            new Employee(){ Name = "Pepe", Role = Role.Developer, Gender = Gender.Male },
            new Employee(){ Name = "Andrea", Role = Role.Executive, Gender = Gender.Female },
            new Employee(){ Name = "Ricardo", Role = Role.Manager, Gender = Gender.Male }
        };

        IEmployeeManager employeeManager = new EmployeeManager();

        foreach (Employee employee in employees)
        {
            employeeManager.Save(employee);
        }

        var search = new EmployeeSearch(employeeManager);

        Console.WriteLine($"La cantidad de empleados con role Executive y genero Male, son: {search.GetEmployeeByGenderAndRole(Gender.Male, Role.Executive)}");
        Console.ReadLine();
    } 
}