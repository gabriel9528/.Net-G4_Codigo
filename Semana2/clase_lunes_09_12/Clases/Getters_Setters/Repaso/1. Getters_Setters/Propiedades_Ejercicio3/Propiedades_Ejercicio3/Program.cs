using System;

public class CuentaBancaria
{
    private string titular;
    private decimal saldo;

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public decimal Saldo
    {
        get { return saldo; }
        private set
        {
            if (value < 0)
            {
                Console.WriteLine("El saldo no puede ser negativo.");
                saldo = 0;
            }
            else
            {
                saldo = value;
            }
        }
    }

    public void Depositar(decimal cantidad)
    {
        Saldo += cantidad;
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad > Saldo)
        {
            Console.WriteLine("Fondos insuficientes.");
        }
        else
        {
            Saldo -= cantidad;
        }
    }
}

class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria();

        Console.Write("Ingrese el nombre del titular: ");
        cuenta.Titular = Console.ReadLine();

        Console.Write("Ingrese la cantidad a depositar: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal deposito))
        {
            cuenta.Depositar(deposito);
        }
        else
        {
            Console.WriteLine("Cantidad inválida. No se realizó el depósito.");
        }

        Console.Write("Ingrese la cantidad a retirar: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal retiro))
        {
            cuenta.Retirar(retiro);
        }
        else
        {
            Console.WriteLine("Cantidad inválida. No se realizó el retiro.");
        }

        Console.WriteLine($"Titular: {cuenta.Titular}, Saldo: {cuenta.Saldo:C}");
    }
}
