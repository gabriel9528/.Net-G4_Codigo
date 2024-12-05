using System;

class Program
{
    static void InvertirArreglo(int[] numeros)
    {
        Array.Reverse(numeros);
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }

    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        InvertirArreglo(numeros);
    }
}
