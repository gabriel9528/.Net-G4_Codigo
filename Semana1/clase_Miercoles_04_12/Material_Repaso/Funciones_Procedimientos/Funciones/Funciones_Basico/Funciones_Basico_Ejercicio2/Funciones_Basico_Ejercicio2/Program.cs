using System;

class Program
{
    static int CalcularCuadrado(int numero)
    {
        return numero * numero;
    }

    static void Main()
    {
        int resultado = CalcularCuadrado(7);
        Console.WriteLine("El cuadrado es: " + resultado);
    }
}
