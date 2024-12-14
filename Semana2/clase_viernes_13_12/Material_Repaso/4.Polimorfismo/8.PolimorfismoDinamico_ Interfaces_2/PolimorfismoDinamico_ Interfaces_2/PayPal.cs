using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoDinamico__Interfaces_2
{
    public class PayPal : IPago
    {
        public string Email { get; set; }

        public PayPal(string email)
        {
            Email = email;
        }

        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago de {monto} mediante PayPal.");
            // Lógica de procesamiento de pago con PayPal
        }

        public string GenerarRecibo()
        {
            return $"Recibo de pago con PayPal para la cuenta: {Email}.";
        }
    }
}
