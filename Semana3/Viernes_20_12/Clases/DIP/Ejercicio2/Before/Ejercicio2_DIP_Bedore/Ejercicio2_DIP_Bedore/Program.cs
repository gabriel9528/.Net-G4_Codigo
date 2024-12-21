
using Ejercicio2_DIP_Bedore;

class Program
{
    static void Main(string[] args)
    {
        //Crear las instancias para email y sms 
        Email email = new Email()
        {
            Subject = "Bienvenido",
            Content = "Hola, Bienvenido a codigo..!!!!"
        };

        SMS sms = new SMS()
        {
            PhoneNumber = "980-963-123",
            Message = "Tu codigo de verificacion es 149-236"
        };

        //Crear instancia para Employee 
        Employee employee = new Employee(email, sms);

        Console.WriteLine("Envio de notificaciones: .............");
        employee.Send();

    }
}