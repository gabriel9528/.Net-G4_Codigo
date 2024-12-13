class Program
{
    static void Main(string[] args)
    {
        //ingresando por teclado
        int suma = 0;
        for(int i = 0; i <= 10; i++)
        {
            suma += i;
        }

        Console.WriteLine($"La suma de los 10 primeros numeros es: {suma}");

    }
}