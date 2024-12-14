using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3A_Abstraccion_Interfaces
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
            Console.WriteLine($"Procesando pago de {monto:C} mediante Tarjeta de Crédito.");
        }

        public string VerificarEstado()
        {
            return "Pago con tarjeta de crédito verificado.";
        }

        public string ObtenerDetalles()
        {
            return $"Tarjeta de Crédito: {NombreTitular}, Número: {NumeroTarjeta}, Expiración: {FechaExpiracion:MM/yyyy}";
        }
    }
}
