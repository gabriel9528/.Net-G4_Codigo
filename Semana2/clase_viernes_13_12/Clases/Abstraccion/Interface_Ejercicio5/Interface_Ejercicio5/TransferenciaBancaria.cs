using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ejercicio5
{
    internal class TransferenciaBancaria : IPago
    {
        public string NumeroCuenta {  get; set; }
        public string Banco {  get; set; }

        public TransferenciaBancaria(string numeroCuenta, string banco)
        {
            NumeroCuenta = numeroCuenta;
            Banco = banco;
        }
        public string ObtenerDetalles()
        {
            return $"TransferenciaBancaria, Numero de cuenta: {NumeroCuenta}, desde el banco: {Banco}";
        }

        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago desde Transferencia Bancaria, monto: {monto} ");
        }

        public void VerificarEstado()
        {
            Console.WriteLine($"Pago verificado con Transferencia Bancaria");
        }
    }
}
