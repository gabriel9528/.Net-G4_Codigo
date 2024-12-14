

using EjercicioFinal1Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Coche("ABC123", "Toyota Corolla", 50, 5),
                new Moto("DEF456", "Yamaha MT-07", 30, "Gasolina"),
                new Camion("GHI789", "Volvo FH16", 100, 12)
            };

        foreach (Vehiculo vehiculo in vehiculos)
        {
            Console.WriteLine($"Vehículo: {vehiculo.Modelo}, Matrícula: {vehiculo.Matricula}, Tarifa Calculada: {vehiculo.CalcularTarifa()}");
        }
    }
}