using Herencia_Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        Cocinero cocinero = new Cocinero("Juan", 48, 2000, "Comida ITliana", 10);
        Camarero camarero = new Camarero("Maria", 28, 2200, 20, 8);
        Gerente gerente = new Gerente("Pedro", 35, 1900, "Restaurante", 20);

        Console.WriteLine("Informacion del cocinero: ");
        cocinero.MostrarInformacion();
        cocinero.MostrarInformacion2();
        Console.WriteLine("*******************************");
        Console.WriteLine("");

        Console.WriteLine("Informacion del camarero: ");
        camarero.MostrarInformacion();
        Console.WriteLine("*******************************");
        Console.WriteLine("");

        Console.WriteLine("Informacion del gerente: ");
        gerente.MostrarInformacion();

    }
}