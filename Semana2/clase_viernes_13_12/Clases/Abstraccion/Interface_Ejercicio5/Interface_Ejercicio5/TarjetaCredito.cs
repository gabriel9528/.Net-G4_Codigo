using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ejercicio5
{
    internal class TarjetaCredito : IPago
    {
        public string NumeroCuenta { get; set; }
        public string Titular { get; set; }
        public DateTime FechaExpiracion { get; set; }

        public TarjetaCredito(string numeroCuenta, string titular, DateTime fechaExpiracion)
        {
            NumeroCuenta = numeroCuenta;
            Titular = titular;
            FechaExpiracion = fechaExpiracion;
        }
        public string ObtenerDetalles()
        {
            return $"TarjetaCredito, Nombre del titular {Titular},  Numero de cuenta: {NumeroCuenta}";
        }

        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago desde TarjetaCredito, monto: {monto} ");
        }

        public void VerificarEstado()
        {
            Console.WriteLine($"Pago verificado con TarjetaCredito");
        }
    }
}
