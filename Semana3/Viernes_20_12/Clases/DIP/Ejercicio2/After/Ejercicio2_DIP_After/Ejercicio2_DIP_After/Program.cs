
using Ejercicio2_DIP_After;

class Program
{
    static void Main(string[] args)
    {
        //Crear mensajes
        List<IMessage> messages = new List<IMessage>()
        {
            new Email{ Subject = "Recordatorio de reunion", Content = "No olvidar la reunion del dia de hoy" },
            new SMS {PhoneNumber = "987-102-356", Message = "Buenos dias, solo paso a recordar la reunion del dia de hoy" }
        };

        //Crear la instancia mi clase Employee(clase de alto nivel)

        var employee = new Employee(messages);

        employee.Send();

    }
}