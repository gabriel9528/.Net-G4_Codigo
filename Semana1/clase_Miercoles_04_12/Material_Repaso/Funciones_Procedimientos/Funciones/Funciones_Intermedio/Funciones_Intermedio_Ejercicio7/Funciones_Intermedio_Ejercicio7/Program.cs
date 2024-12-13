using System;

class Program
{
    static string DeterminarTipoTriangulo(int lado1, int lado2, int lado3)
    {
        if (lado1 == lado2 && lado2 == lado3)
            return "Equilátero";
        else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            return "Isósceles";
        else
            return "Escaleno";
    }

    static void Main()
    {
        Console.WriteLine("Ingrese los tres lados del triángulo:");
        int lado1 = int.Parse(Console.ReadLine());
        int lado2 = int.Parse(Console.ReadLine());
        int lado3 = int.Parse(Console.ReadLine());

        string tipo = DeterminarTipoTriangulo(lado1, lado2, lado3);
        Console.WriteLine("El triángulo es: " + tipo);
    }
}
