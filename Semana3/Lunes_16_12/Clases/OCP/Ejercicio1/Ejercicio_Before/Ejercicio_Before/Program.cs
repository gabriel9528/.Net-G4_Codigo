using Ejercicio_Before;

class Program
{
    static void Main(string[] args)
    {
        List<Person> listPerson = new List<Person>()
        {
            new Person(){ FirstName = "Rodrigo", LastName = "Carpio", Role = Role.Doctor },
            new Person(){ FirstName = "Micaela", LastName = "Torres", Role = Role.Nurse },
            new Person(){ FirstName = "Robert", LastName = "Semansky"}
        };

        List<Staff> listStaff = new List<Staff>();

        foreach (Person person in listPerson)
        {
            listStaff.Add(new AccountService().Create(person));
        }

        foreach (Staff staff in listStaff)
        {
            Console.WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName}, {staff.Email}. " +
                $"Es doctor:{(staff.Role == Role.Doctor ? " SI" : " NO")}, " +
                $"Es Enfermera:{(staff.Role == Role.Nurse ? " SI" : " NO")}");
        }

        Console.ReadLine();
    }
}