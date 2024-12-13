using System;

public static class Contador
{
    // Variable estática que guarda el contador
    private static int contador = 0;

    // Método estático para incrementar el contador
    public static void IncrementarContador()
    {
        contador++;
    }

    // Método estático para obtener el valor del contador
    public static int ObtenerContador()
    {
        return contador;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Accediendo al contador...");

        // Incrementando el contador
        Contador.IncrementarContador();
        Contador.IncrementarContador();
        Contador.IncrementarContador();
        Contador.IncrementarContador();

        // Mostrando el valor del contador
        Console.WriteLine($"El contador actual es: {Contador.ObtenerContador()}");

        // Incrementando nuevamente el contador
        Contador.IncrementarContador();
        Console.WriteLine($"El contador después de un incremento adicional es: {Contador.ObtenerContador()}");
    }
}
