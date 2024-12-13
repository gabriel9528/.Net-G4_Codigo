using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int valor = 1;
        int sumaTotal = 0;

        // Llenar la matriz
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = valor++;
                sumaTotal += matriz[i, j];
            }
        }

        // Imprimir la matriz
        Console.WriteLine("Matriz:");
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
