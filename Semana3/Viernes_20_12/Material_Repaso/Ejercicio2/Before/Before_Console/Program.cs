using Before;

public class Program
{
    public static void Main(string[] args)
    {
        // Crear instancias de Email y SMS con datos de ejemplo
        Email email = new Email
        {
            Subject = "Bienvenida",
            Content = "¡Hola! Bienvenido a nuestra plataforma."
        };

        SMS sms = new SMS
        {
            PhoneNumber = "987654321",
            Message = "Tu código de verificación es 123456."
        };

        // Crear instancia de Employee con las dependencias Email y SMS
        Employee employee = new Employee(email, sms);

        // Llamar al método Send para enviar notificaciones
        Console.WriteLine("Enviando notificaciones...");
        employee.Send();
    }
}