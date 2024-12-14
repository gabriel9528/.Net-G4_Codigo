using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3A_Abstraccion_Interfaces
{
    public class TransferenciaBancaria : IPago
    {
        public string NumeroCuenta { get; set; }
        public string Banco { get; set; }

        public TransferenciaBancaria(string numeroCuenta, string banco)
        {
            NumeroCuenta = numeroCuenta;
            Banco = banco;
        }

        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago de {monto:C} mediante Transferencia Bancaria.");
        }

        public string VerificarEstado()
        {
            return "Pago con transferencia bancaria verificado.";
        }

        public string ObtenerDetalles()
        {
            return $"Transferencia Bancaria: Cuenta {NumeroCuenta}, Banco: {Banco}";
        }
    }
}
