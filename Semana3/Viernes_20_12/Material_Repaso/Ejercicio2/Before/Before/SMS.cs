using System;

namespace Before
{
    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            // Simular el envío de un SMS
            Console.WriteLine($"SMS enviado a {PhoneNumber}: {Message}");
        }
    }
}