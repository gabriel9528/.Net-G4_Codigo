using System;

class Program
{
    static int CalcularMenor(int[] numeros)
    {
        int menor = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero < menor)
            {
                menor = numero;
            }
        }
        return menor;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de números:");
        int cantidad = int.Parse(Console.ReadLine());
        int[] numeros = new int[cantidad];

        Console.WriteLine("Ingrese los números:");
        for (int i = 0; i < cantidad; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int menor = CalcularMenor(numeros);
        Console.WriteLine("El menor número es: " + menor);
    }
}
