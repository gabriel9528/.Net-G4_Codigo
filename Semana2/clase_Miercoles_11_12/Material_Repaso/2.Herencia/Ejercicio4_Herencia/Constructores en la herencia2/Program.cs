using Constructores_en_la_herencia2;

class Program
{
    static void Main(string[] args)
    {
        Cocinero cocinero = new Cocinero("Juan", 35, 2500, "Italiana", 10);
        Camarero camarero = new Camarero("María", 28, 1800, 50, "Avanzado");
        Gerente gerente = new Gerente("Pedro", 45, 4000, "Restaurante", 15);

        Console.WriteLine("Información del cocinero:");
        cocinero.MostrarInformacion();
        Console.WriteLine();

        Console.WriteLine("Información del camarero:");
        camarero.MostrarInformacion();
        Console.WriteLine();

        Console.WriteLine("Información del gerente:");
        gerente.MostrarInformacion();
    }
}