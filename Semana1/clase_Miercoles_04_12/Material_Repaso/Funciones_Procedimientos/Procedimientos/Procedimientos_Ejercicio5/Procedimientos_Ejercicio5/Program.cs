using System;

class Program
{
    static void OrdenarArregloBurbuja(int[] numeros)
    {
        int n = numeros.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Arreglo ordenado:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }

    static void Main()
    {
        int[] numeros = { 5, 3, 8, 4, 2 };
        OrdenarArregloBurbuja(numeros);
    }
}
