using System;

public class CuentaBancaria
{
    public string NumeroCuenta { get; set; }
    public decimal Saldo { get; private set; }

    public CuentaBancaria(string numeroCuenta)
    {
        NumeroCuenta = numeroCuenta;
        Saldo = 0;
    }

    public void Depositar(decimal monto)
    {
        Saldo += monto;
        Console.WriteLine($"Depósito: {monto:C}, Saldo actual: {Saldo:C}");
    }

    public void Retirar(decimal monto)
    {
        if (monto <= Saldo)
        {
            Saldo -= monto;
            Console.WriteLine($"Retiro: {monto:C}, Saldo actual: {Saldo:C}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese el número de cuenta: ");
        string numeroCuenta = Console.ReadLine();

        CuentaBancaria cuenta = new CuentaBancaria(numeroCuenta);

        Console.Write("Ingrese el monto a depositar: ");
        decimal montoDeposito;
        if (decimal.TryParse(Console.ReadLine(), out montoDeposito))
        {
            cuenta.Depositar(montoDeposito);
        }
        else
        {
            Console.WriteLine("Monto de depósito no válido.");
        }

        Console.Write("Ingrese el monto a retirar: ");
        decimal montoRetiro;
        if (decimal.TryParse(Console.ReadLine(), out montoRetiro))
        {
            cuenta.Retirar(montoRetiro);
        }
        else
        {
            Console.WriteLine("Monto de retiro no válido.");
        }
    }
}
