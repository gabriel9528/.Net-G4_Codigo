

using Encapsulamiento_Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        //Crear cuentas bancarias
        Console.WriteLine("Ingrese los datos de la primera cuenta bancaria: ");
        CuentaBancaria cuenta1 = CrearCuentaBancariaDesdeTeclado();

        Console.WriteLine("\nIngrese los datos de la segunda cuenta bancaria: ");
        CuentaBancaria cuenta2 = CrearCuentaBancariaDesdeTeclado();

        //Menu Principal
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nSeleccione la cuenta bancaria para realizar sus operaciones");
            Console.WriteLine("1. Primera Cuenta");
            Console.WriteLine("2. Segunda Cuenta");
            Console.WriteLine("3. Salir");

            Console.WriteLine("Opcion: ");
            int opcionCuenta = int.Parse(Console.ReadLine());

            switch (opcionCuenta)
            {
                case 1:
                    Console.WriteLine("\nOperaciones para la primera cuenta: ");
                    RealizarOperaciones(cuenta1);
                    break;

                case 2:
                    Console.WriteLine("\nOperaciones para la segunda cuenta: ");
                    RealizarOperaciones(cuenta2);
                    break;

                case 3:
                    continuar = false;
                    Console.WriteLine("Gracias por usar nuestro porgama, vuelva pronto.");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }


    private static void RealizarOperaciones(CuentaBancaria cuenta)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nSeleccione la operacion: ");
            Console.WriteLine("1. Depositar saldo");
            Console.WriteLine("2. Reirar saldo");
            Console.WriteLine("3. Ver saldo");
            Console.WriteLine("4. Volver al menu principal");

            Console.WriteLine("Opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el monto a depositar: ");
                    if(decimal.TryParse(Console.ReadLine(), out decimal montoDepositado))
                    {
                        cuenta.Depositar(montoDepositado);
                    }
                    else
                    {
                        Console.WriteLine("Monto invalido");
                    }
                    break;

                case 2:
                    Console.WriteLine("Ingrese el monto a retirar: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal montoRetirado))
                    {
                        cuenta.Retirar(montoRetirado);
                    }
                    else
                    {
                        Console.WriteLine("Monto invalido");
                    }
                    break;

                case 3:
                    Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo()}");
                    break;

                case 4:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }
    }

    private static CuentaBancaria CrearCuentaBancariaDesdeTeclado()
    {
        Console.WriteLine("Numero de cuenta: ");
        string numeroCuenta = Console.ReadLine();


        Console.WriteLine("Propietario: ");
        string propietario = Console.ReadLine();

        Console.WriteLine("Saldo inicial: ");
        decimal saldoInicial;
        while(!decimal.TryParse(Console.ReadLine(), out saldoInicial) || saldoInicial < 0)
        {
            Console.WriteLine("Porfavor ingrese un saldo inicial valido(mayor a cero)");
        }

        return new CuentaBancaria(numeroCuenta, propietario, saldoInicial);

    }
}