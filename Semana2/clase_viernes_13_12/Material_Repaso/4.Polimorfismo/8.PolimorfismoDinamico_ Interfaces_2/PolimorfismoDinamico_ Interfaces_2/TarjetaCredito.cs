using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoDinamico__Interfaces_2
{
    public class TarjetaCredito : IPago
    {
        public string NumeroTarjeta { get; set; }
        public string NombreTitular { get; set; }
        public DateTime FechaExpiracion { get; set; }

        public TarjetaCredito(string numeroTarjeta, string nombreTitular, DateTime fechaExpiracion)
        {
            NumeroTarjeta = numeroTarjeta;
            NombreTitular = nombreTitular;
            FechaExpiracion = fechaExpiracion;
        }

        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago de {monto} mediante tarjeta de crédito.");
            // Lógica de procesamiento de pago con tarjeta de crédito
        }

        public string GenerarRecibo()
        {
            return $"Recibo de pago con tarjeta de crédito para {NombreTitular}, Número de Tarjeta: {NumeroTarjeta}.";
        }
    }
}
