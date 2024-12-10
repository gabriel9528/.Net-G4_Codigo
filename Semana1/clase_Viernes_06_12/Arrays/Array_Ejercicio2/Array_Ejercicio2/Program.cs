class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"ingrese el numero de la posicion {i}");
            numbers[i] =  int.Parse(Console.ReadLine());
        }

        //Encontrar el valor Maximo y Minimo
        int max = numbers.Max();
        int min = numbers.Min();

        Console.WriteLine($"El maximo valor es: { max }");
        Console.WriteLine($"El minimo valor es: { min }");
    }
}