using Ejercicio_Before;

class Program
{
    static void Main(string[] args)
    {
        List<IPerson> listPerson = new List<IPerson>()
        {
            new Doctor(){ FirstName = "Rodrigo", LastName = "Carpio" },
            new Nurse(){ FirstName = "Micaela", LastName = "Torres" },
            new Staff(){ FirstName = "Robert", LastName = "Semansky"}
        };

        List<Staff_1> listStaff = new List<Staff_1>();

        foreach (IPerson person in listPerson)
        {
            listStaff.Add(person.IAccountService.Create(person));
        }

        foreach (Staff_1 staff in listStaff)
        {
            Console.WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName}, {staff.Email}. ");
        }

        Console.ReadLine();
    }
}