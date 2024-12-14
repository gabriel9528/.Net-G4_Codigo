using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ejercicio5
{
    internal class PayPal : IPago
    {
        public string CorreoElectronico {  get; set; }

        public PayPal(string correoElectronico)
        {
            CorreoElectronico = correoElectronico;
        }


        public string ObtenerDetalles()
        {
            return $"Paypal: {CorreoElectronico}";
        }

        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago desde Paypal, monto: {monto} ");
        }

        public void VerificarEstado()
        {
            Console.WriteLine($"Pago verificado con Paypal");
        }
    }
}
