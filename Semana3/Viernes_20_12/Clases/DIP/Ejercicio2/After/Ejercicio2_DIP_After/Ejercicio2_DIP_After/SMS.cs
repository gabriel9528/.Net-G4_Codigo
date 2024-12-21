using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_DIP_After
{
    internal class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Esto es un SMS"); 
        }
    }
}
