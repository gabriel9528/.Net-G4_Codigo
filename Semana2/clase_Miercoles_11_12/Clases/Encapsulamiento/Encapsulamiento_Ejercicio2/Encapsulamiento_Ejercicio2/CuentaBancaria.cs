using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento_Ejercicio2
{
    public class CuentaBancaria
    {
        //Atributos
        private string numeroCuenta;
        private string propietario;
        private decimal _saldo;

        //Constructor
        public CuentaBancaria(string numeroCuenta, string propietario, decimal saldoInicial) 
        {
            this.numeroCuenta = numeroCuenta;
            this.propietario = propietario;
            _saldo = saldoInicial > 0 ? saldoInicial : 0;
        }

        public void Depositar(decimal monto)
        {
            if(monto > 0)
            {
                _saldo += monto;
                Console.WriteLine($"El monto depositado es: {monto} en la cuenta {numeroCuenta}");
            }
            else
            {
                Console.WriteLine($"El monto ha depositar tiene que ser positivo");
            }
        }


        public void Retirar(decimal monto)
        {
            if (monto > 0 && monto <= _saldo)
            {
                _saldo -= monto;
                Console.WriteLine($"Se ha retirado: {monto} en la cuenta {numeroCuenta}; saldo actual: {_saldo}");
            }
            else if(monto > _saldo)
            {
                Console.WriteLine($"El monto no puede ser mayor que el saldo");
            }
            else
            {
                Console.WriteLine($"El monto ha retirar tiene que ser mayor que 0");
            }
        }

        public decimal ObtenerSaldo()
        {
            return _saldo;
        }

        public override string ToString()
        {
            return $"Numero de cuenta: {numeroCuenta}, Propietario: {propietario}";
        }

    }
}
