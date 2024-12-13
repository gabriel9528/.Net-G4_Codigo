using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int sumaTotal = 0;

        // Llenar la matriz con el producto de los índices
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = i * j;
                sumaTotal += matriz[i, j];
            }
        }

        // Imprimir la matriz
        Console.WriteLine("Contenido de la matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Imprimir la suma total
        Console.WriteLine($"Suma total de los elementos: {sumaTotal}");
    }
}
