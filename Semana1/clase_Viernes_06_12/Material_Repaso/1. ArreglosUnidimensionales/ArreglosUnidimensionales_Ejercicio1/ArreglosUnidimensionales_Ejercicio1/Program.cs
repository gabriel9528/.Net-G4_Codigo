using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        // Inicializar el arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = i + 1; // Asignamos los números del 1 al 10
        }

        // Imprimir los elementos
        Console.WriteLine("Elementos del arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Elemento en índice {i}: {numeros[i]}");
        }

        // Imprimir el tamaño del arreglo
        Console.WriteLine($"Tamaño del arreglo: {numeros.Length}");
    }
}
