using SRP_Before;

class Program
{
    static void Main(string[] args)
    {
        DateTime checkInDate = DateTime.Now;

        Console.WriteLine(new AppoinmentService().Create("Pepito Flores", "pepito1@gmail.com", checkInDate));
        Console.ReadLine();
    }
}