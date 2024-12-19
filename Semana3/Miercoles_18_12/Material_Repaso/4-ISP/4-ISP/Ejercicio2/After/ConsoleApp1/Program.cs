

using ISPLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demostración del Principio de Segregación de Interfaces (ISP):");

        // Instancia de Car
        Console.WriteLine("\nUsando el vehículo Car:");
        IVehicle car = new Car();
        IEngineVehicle engineCar = new Car();

        Console.WriteLine($"Número de ruedas: {car.GetNumberOfWheel()}");
        car.Move();
        engineCar.startEngine();
        engineCar.stopEngine();


        //***************************************************************************************************

        // Instancia de Bicycle
        Console.WriteLine("\nUsando el vehículo Bicycle:");
        IVehicle bicycle = new Bicycle();

        Console.WriteLine($"Número de ruedas: {bicycle.GetNumberOfWheel()}");
        bicycle.Move();

        // Nota: Bicycle no implementa IEngineVehicle, por lo que no tiene motor.
        Console.WriteLine("La bicicleta no tiene motor, por lo que no se pueden ejecutar métodos relacionados con el motor.");

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}