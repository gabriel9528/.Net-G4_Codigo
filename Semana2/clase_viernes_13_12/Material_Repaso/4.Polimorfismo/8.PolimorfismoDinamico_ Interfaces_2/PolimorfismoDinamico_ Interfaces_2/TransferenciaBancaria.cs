using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoDinamico__Interfaces_2
{
    public class TransferenciaBancaria : IPago
    {
        public string NumeroCuenta { get; set; }
        public string NombreBanco { get; set; }

        public TransferenciaBancaria(string numeroCuenta, string nombreBanco)
        {
            NumeroCuenta = numeroCuenta;
            NombreBanco = nombreBanco;
        }

        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago de {monto} mediante transferencia bancaria.");
            // Lógica de procesamiento de pago con transferencia bancaria
        }

        public string GenerarRecibo()
        {
            return $"Recibo de pago con transferencia bancaria, Banco: {NombreBanco}, Número de Cuenta: {NumeroCuenta}.";
        }
    }
}
