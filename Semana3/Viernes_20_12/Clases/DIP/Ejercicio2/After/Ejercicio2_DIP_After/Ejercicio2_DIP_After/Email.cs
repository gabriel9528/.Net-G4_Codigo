using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_DIP_After
{
    internal class Email : IMessage
    {
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Esto es un Email");
        }
    }
}
