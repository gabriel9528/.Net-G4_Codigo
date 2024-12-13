using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Invertir el arreglo
        for (int i = 0; i < numeros.Length / 2; i++)
        {
            int temp = numeros[i];
            numeros[i] = numeros[numeros.Length - 1 - i];
            numeros[numeros.Length - 1 - i] = temp;
        }

        // Mostrar el arreglo invertido
        Console.WriteLine("Arreglo invertido:");
        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
