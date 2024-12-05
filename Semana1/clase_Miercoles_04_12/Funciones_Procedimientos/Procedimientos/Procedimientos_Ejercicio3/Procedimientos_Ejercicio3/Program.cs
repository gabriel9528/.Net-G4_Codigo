using System;

class Program
{
    static void MostrarArreglo(int[] numeros)
    {
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }

    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        MostrarArreglo(numeros);
    }
}
