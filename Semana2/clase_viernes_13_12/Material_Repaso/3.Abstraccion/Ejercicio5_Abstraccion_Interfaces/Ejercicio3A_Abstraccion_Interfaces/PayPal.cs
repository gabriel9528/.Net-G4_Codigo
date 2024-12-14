using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3A_Abstraccion_Interfaces
{
    public class PayPal : IPago
    {
        public string CorreoElectronico { get; set; }

        public PayPal(string correoElectronico)
        {
            CorreoElectronico = correoElectronico;
        }

        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago de {monto:C} mediante PayPal.");
        }

        public string VerificarEstado()
        {
            return "Pago con PayPal verificado.";
        }

        public string ObtenerDetalles()
        {
            return $"PayPal: {CorreoElectronico}";
        }
    }
}
