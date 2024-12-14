

using Ejercicio3CC_Abstracciones_ClasesAbstractas;

class Program
{
    static void Main()
    {
        // Crear instancias de cada tipo de vehículo
        Vehiculo coche = new Coche("Toyota", "Corolla");
        Vehiculo motocicleta = new Motocicleta("Honda", "CBR600RR");
        Vehiculo camion = new Camion("Volvo", "FH16");

        // Arreglo de vehículos
        Vehiculo[] vehiculos = { coche, motocicleta, camion };

        // Iniciar, detener y obtener detalles de cada vehículo
        foreach (Vehiculo vehiculo in vehiculos)
        {
            vehiculo.Iniciar();
            vehiculo.Detener();
            Console.WriteLine(vehiculo.ObtenerDetalles());
            Console.WriteLine();
        }
    }
}