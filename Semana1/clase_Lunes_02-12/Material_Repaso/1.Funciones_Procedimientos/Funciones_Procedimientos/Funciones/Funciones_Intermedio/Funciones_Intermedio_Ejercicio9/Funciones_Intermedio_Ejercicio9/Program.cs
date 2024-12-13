using System;

class Program
{
    static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Ingrese un número para calcular su factorial:");
        int numero = int.Parse(Console.ReadLine());

        int resultado = Factorial(numero);
        Console.WriteLine("El factorial de " + numero + " es: " + resultado);
    }
}
