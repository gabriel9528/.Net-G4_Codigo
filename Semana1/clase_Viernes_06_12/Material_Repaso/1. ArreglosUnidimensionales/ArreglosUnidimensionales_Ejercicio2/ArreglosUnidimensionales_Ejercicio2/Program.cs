using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        // Leer los números desde la consola
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Encontrar el valor máximo y mínimo
        int max = numeros[0];
        int min = numeros[0];

        foreach (var numero in numeros)
        {
            if (numero > max) max = numero;
            if (numero < min) min = numero;
        }

        Console.WriteLine($"Número máximo: {max}");
        Console.WriteLine($"Número mínimo: {min}");
    }
}
