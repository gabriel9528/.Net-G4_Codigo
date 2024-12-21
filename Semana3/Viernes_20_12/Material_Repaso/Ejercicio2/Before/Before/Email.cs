using System;

namespace Before
{
    public class Email
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            // Simular el envío de un email
            Console.WriteLine($"Email enviado:");
            Console.WriteLine($"Asunto: {Subject}");
            Console.WriteLine($"Contenido: {Content}");
        }
    }
}