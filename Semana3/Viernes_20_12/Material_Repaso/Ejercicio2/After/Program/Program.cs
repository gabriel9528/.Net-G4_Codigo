using After;

class Program
{
    static void Main(string[] args)
    {
        // Creating messages
        List<IMessage> messages = new List<IMessage>
            {
                new Email { Subject = "Recordatorio de Reunion", Content = "No olvidar la reunion de hoy dia!" },
                new SMS { PhoneNumber = "123456789", Message = "Buneas, solo paso a recordarle la reunion de hoy dia." }
            };

        Employee employee = new Employee(messages);

        employee.Send();
    }
}