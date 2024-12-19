using ISPLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demostración del Principio de Segregación de Interfaces (ISP):");

        // Instancia de Car
        Console.WriteLine("\nUsando el vehículo Car:");
        IVehicle car = new Car();

        Console.WriteLine($"Número de ruedas: {car.GetNumberOfWheel()}");
        car.Move();
        Console.WriteLine($"Arrancar motor: {car.startEngine()}");
        Console.WriteLine($"Detener motor: {car.stopEngine()}");

        // Instancia de Bicycle
        Console.WriteLine("\nUsando el vehículo Bicycle:");
        IVehicle bicycle = new Bicycle();

        Console.WriteLine($"Número de ruedas: {bicycle.GetNumberOfWheel()}");
        bicycle.Move();

        try
        {
            // Intentar arrancar el motor de la bicicleta
            Console.WriteLine($"Arrancar motor: {bicycle.startEngine()}");
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("El método startEngine no está implementado para Bicycle.");
        }

        try
        {
            // Intentar detener el motor de la bicicleta
            Console.WriteLine($"Detener motor: {bicycle.stopEngine()}");
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("El método stopEngine no está implementado para Bicycle.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}