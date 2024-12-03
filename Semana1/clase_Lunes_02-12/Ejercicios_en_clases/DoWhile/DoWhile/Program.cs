class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio con Do While");

        int suma = 0;
        int number;

        do
        {
            Console.WriteLine("Ingrese un numero a sumarse: ");
            number = Convert.ToInt32(Console.ReadLine());
            suma += number;

        }
        while(number != 0);

        Console.WriteLine($"La suma total es: {suma}");
    }
}