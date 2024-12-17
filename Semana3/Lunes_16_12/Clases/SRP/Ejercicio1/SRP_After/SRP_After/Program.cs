using SRP_After;

class Program
{
    static void Main(string[] args)
    {
        var appoinment = new Appoinment()
        {

            Patient = new Patient()
            {
                Name = "",
                Email = "pepitofloresgmail.com"
            }
        };

        Console.WriteLine(new AppoinmentService().Create(appoinment));

        Console.ReadLine();
    }
}