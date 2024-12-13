using System;

class Program
{
    static void Sumar(int a, int b) => Console.WriteLine("La suma es: " + (a + b));
    static void Restar(int a, int b) => Console.WriteLine("La resta es: " + (a - b));
    static void Multiplicar(int a, int b) => Console.WriteLine("La multiplicación es: " + (a * b));
    static void Dividir(int a, int b)
    {
        if (b != 0)
            Console.WriteLine("La división es: " + (a / (float)b));
        else
            Console.WriteLine("No se puede dividir entre cero");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");
    }

    static void Main()
    {
        int opcion;
        do
        {
            MostrarMenu();
            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= 4)
            {
                Console.WriteLine("Ingrese dos números:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Sumar(num1, num2); break;
                    case 2: Restar(num1, num2); break;
                    case 3: Multiplicar(num1, num2); break;
                    case 4: Dividir(num1, num2); break;
                }
            }
            else if (opcion != 5)
            {
                Console.WriteLine("Opción no válida.");
            }

        } while (opcion != 5);

        Console.WriteLine("Programa finalizado.");
    }
}
