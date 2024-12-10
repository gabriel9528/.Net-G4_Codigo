class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3, 3];

        int valor = 1;
        int sumaTotal = 0;

        //Llenar matriz
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = valor++;
                sumaTotal += matriz[i, j];
            }
        }

        //Imprimir la matriz
        for(int i = 0;i < matriz.GetLength(0); i++)
        {
            for (int j = 0;j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"La suma total de los elementos es: {sumaTotal}");
    }
}