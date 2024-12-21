using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_DIP_Bedore
{
    internal class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //Simular el envio de un mensaje de texto
            Console.WriteLine($"SMS enviado a {PhoneNumber}: {Message}");
        }
    }
}
