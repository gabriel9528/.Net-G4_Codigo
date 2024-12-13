using Ejercicio4;

public class Program
{
    public static void Main(string[] args)
    {
        // Crear cuentas bancarias a partir de la entrada del usuario
        Console.WriteLine("Ingrese los datos de la primera cuenta:");
        CuentaBancaria cuenta1 = CrearCuentaDesdeTeclado();

        Console.WriteLine("\nIngrese los datos de la segunda cuenta:");
        CuentaBancaria cuenta2 = CrearCuentaDesdeTeclado();

        // Menú principal
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nSeleccione la cuenta para realizar operaciones:");
            Console.WriteLine("1. Primera cuenta");
            Console.WriteLine("2. Segunda cuenta");
            Console.WriteLine("3. Salir");

            Console.Write("Opción: ");
            string opcionCuenta = Console.ReadLine();

            switch (opcionCuenta)
            {
                case "1":
                    Console.WriteLine("\nOperaciones para la primera cuenta:");
                    RealizarOperaciones(cuenta1);
                    break;

                case "2":
                    Console.WriteLine("\nOperaciones para la segunda cuenta:");
                    RealizarOperaciones(cuenta2);
                    break;

                case "3":
                    continuar = false;
                    Console.WriteLine("Gracias por usar el sistema de gestión de cuentas bancarias.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    private static CuentaBancaria CrearCuentaDesdeTeclado()
    {
        Console.Write("Número de cuenta: ");
        string numeroCuenta = Console.ReadLine();

        Console.Write("Propietario: ");
        string propietario = Console.ReadLine();

        Console.Write("Saldo inicial: ");
        decimal saldoInicial;
        while (!decimal.TryParse(Console.ReadLine(), out saldoInicial) || saldoInicial < 0)
        {
            Console.WriteLine("Por favor, ingrese un saldo inicial válido (mayor o igual a 0):");
        }

        return new CuentaBancaria(numeroCuenta, propietario, saldoInicial);
    }

    private static void RealizarOperaciones(CuentaBancaria cuenta)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nSeleccione una operación:");
            Console.WriteLine("1. Depositar dinero");
            Console.WriteLine("2. Retirar dinero");
            Console.WriteLine("3. Ver saldo");
            Console.WriteLine("4. Volver al menú principal");

            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el monto a depositar: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal montoDeposito))
                    {
                        cuenta.Depositar(montoDeposito);
                    }
                    else
                    {
                        Console.WriteLine("Monto inválido.");
                    }
                    break;

                case "2":
                    Console.Write("Ingrese el monto a retirar: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal montoRetiro))
                    {
                        cuenta.Retirar(montoRetiro);
                    }
                    else
                    {
                        Console.WriteLine("Monto inválido.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo():C}");
                    break;

                case "4":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}