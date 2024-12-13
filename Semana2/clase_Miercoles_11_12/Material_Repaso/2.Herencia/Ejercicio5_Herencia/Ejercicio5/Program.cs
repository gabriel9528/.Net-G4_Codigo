using Ejercicio5;

class Program
{
    static void Main()
    {
        // Crear objetos de tipo Carro y Camion
        Carro carro1 = new Carro("Toyota", "Corolla", 2020, 4, 4);
        Camion camion1 = new Camion("Mercedes-Benz", "Actros", 2019, 18, 25);

        // Mostrar información de los vehículos
        Console.WriteLine("Información del Carro:");
        carro1.MostrarInformacion();
        Console.WriteLine($"Consumo de Combustible para 200 km: {carro1.CalcularConsumoCombustible(200)} litros");
        Console.WriteLine();

        Console.WriteLine("Información del Camión:");
        camion1.MostrarInformacion();
        Console.WriteLine($"Consumo de Combustible para 200 km: {camion1.CalcularConsumoCombustible(200)} litros");
    }
}