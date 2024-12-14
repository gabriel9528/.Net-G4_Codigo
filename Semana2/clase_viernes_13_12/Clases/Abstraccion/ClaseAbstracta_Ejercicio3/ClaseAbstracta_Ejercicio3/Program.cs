

using ClaseAbstracta_Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        //Crear instancias para cada vehiculo
        Vehiculo coche = new Coche("Toyota", "Raizen");
        Vehiculo camion = new Camion("Volvo", "Tracto");
        Vehiculo motocicleta = new Motocicleta("Honda", "CBR-500", "Original");

        Vehiculo[] vehiculos = { coche, camion, motocicleta };


        foreach(var vehiculo in vehiculos)
        {
            vehiculo.Iniciar();
            vehiculo.Detener();
            vehiculo.ObtenerDetalles();
            Console.WriteLine("***************");
            Console.WriteLine("");
        }
    }
}