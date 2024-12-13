class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3, 3];

        int sumaTotal = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = i * j;
                sumaTotal += matriz[i, j];
            }
        }

        //Imprimir la matriz por consola
        Console.WriteLine("Los elementos de la matriz son: ");
        Console.WriteLine("******************************* ");
        for (int i = 0;i < matriz.GetLength(0); i++)
        {
            for(int j = 0;j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        //Imprimir la suma total:
        Console.WriteLine($"La suma de los elementos de la matriz es: {sumaTotal}");
    }
}