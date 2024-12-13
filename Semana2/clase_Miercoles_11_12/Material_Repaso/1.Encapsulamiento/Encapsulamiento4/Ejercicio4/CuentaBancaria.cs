using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class CuentaBancaria
    {
        // Atributos privados
        private string numeroCuenta;
        private string propietario;
        private decimal saldo;

        // Constructor
        public CuentaBancaria(string numeroCuenta, string propietario, decimal saldoInicial)
        {
            this.numeroCuenta = numeroCuenta;
            this.propietario = propietario;
            saldo = saldoInicial > 0 ? saldoInicial : 0;
        }

        // Métodos públicos que aplican encapsulación
        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                saldo += monto;
                Console.WriteLine($"Se han depositado {monto:C} en la cuenta {numeroCuenta}. Saldo actual: {saldo:C}");
            }
            else
            {
                Console.WriteLine("El monto a depositar debe ser mayor que cero.");
            }
        }

        public void Retirar(decimal monto)
        {
            if (monto > 0 && monto <= saldo)
            {
                saldo -= monto;
                Console.WriteLine($"Se han retirado {monto:C} de la cuenta {numeroCuenta}. Saldo actual: {saldo:C}");
            }
            else if (monto > saldo)
            {
                Console.WriteLine("Fondos insuficientes para realizar el retiro.");
            }
            else
            {
                Console.WriteLine("El monto a retirar debe ser mayor que cero.");
            }
        }

        public decimal ObtenerSaldo()
        {
            return saldo;
        }

        public override string ToString()
        {
            return $"Número de Cuenta: {numeroCuenta}, Propietario: {propietario}";
        }
    }
}
