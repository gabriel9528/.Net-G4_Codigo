using System;

class Program
{
    static void Main()
    {
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Imprimir la matriz
        //En el código, se utiliza el método GetLength(0) para obtener el número de filas y
        //GetLength(1) para obtener el número de columnas:
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
