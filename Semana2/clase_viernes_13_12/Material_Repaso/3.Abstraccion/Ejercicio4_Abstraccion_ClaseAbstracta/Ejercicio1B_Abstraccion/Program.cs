
using Ejercicio1B_Abstraccion;

class Program
{
    static void Main()
    {
        // Crear instancias de cada tipo de dispositivo
        Dispositivo telefonoMovil = new TelefonoMovil("Apple", "iPhone 12", 2020);
        Dispositivo tablet = new Tablet("Samsung", "Galaxy Tab S7", 2021);
        Dispositivo laptop = new Laptop("Dell", "XPS 13", 2019);

        // Llamar a los métodos comunes
        telefonoMovil.Encender();
        Console.WriteLine(telefonoMovil.ObtenerInfo());
        telefonoMovil.Apagar();

        tablet.Encender();
        Console.WriteLine(tablet.ObtenerInfo());
        tablet.Apagar();

        laptop.Encender();
        Console.WriteLine(laptop.ObtenerInfo());
        laptop.Apagar();
    }
}
