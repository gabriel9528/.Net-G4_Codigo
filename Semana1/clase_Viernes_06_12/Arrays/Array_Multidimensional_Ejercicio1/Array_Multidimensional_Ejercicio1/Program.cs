class Program
{
    static void Main()
    {
        int[,] matriz = { { 10, 5, 8 }, { 30, 1, 20 } };

        //Imprimir la matriz

        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }

            Console.WriteLine();
        }

    }
}