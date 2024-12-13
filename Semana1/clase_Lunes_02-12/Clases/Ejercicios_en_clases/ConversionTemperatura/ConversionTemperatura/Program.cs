class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio de conversio  deCelsius a Farinhet:");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Ingrese la temperatura en celsius que desea convertir:");

        var temperature = Console.ReadLine();
        double conversion = 0;
        if (!string.IsNullOrEmpty(temperature))
        {
            if (Double.TryParse(temperature, out double result))
            {
                result = Convert.ToDouble(temperature);
                conversion = ((9 * result) / 5) + 32;
            }
            else
            {
                Console.WriteLine("No se puede convertir");
            }
        }

        Console.WriteLine($"La conversion de grados celsius a farenheit es: {conversion}");
    }
}