using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_DIP_Bedore
{
    internal class Email
    {
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendEmail()
        {
            //Simular el envio de un Email
            Console.WriteLine("Email enviado: ");
            Console.WriteLine($"Asunto enviado: {Subject}");
            Console.WriteLine($"Contenido: {Content}");
        }
    }
}
