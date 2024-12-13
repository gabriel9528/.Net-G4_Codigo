using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[6];
        Random rand = new Random();

        // Inicializar el arreglo con números aleatorios entre 1 y 100
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = rand.Next(1, 101);
        }

        // Calcular el promedio
        int suma = 0;
        foreach (var numero in numeros)
        {
            suma += numero;
        }

        double promedio = suma / (double)numeros.Length;

        // Imprimir los números y el promedio
        Console.WriteLine("Elementos del arreglo:");
        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine($"Promedio: {promedio}");
    }
}
