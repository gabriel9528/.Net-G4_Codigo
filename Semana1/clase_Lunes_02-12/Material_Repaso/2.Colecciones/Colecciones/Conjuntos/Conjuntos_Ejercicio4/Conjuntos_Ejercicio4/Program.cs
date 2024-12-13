using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        HashSet<string> librosPrestados = new HashSet<string>();
        HashSet<string> librosReservados = new HashSet<string>();

        Console.WriteLine("Ingrese títulos de libros prestados (escriba 'fin' para terminar):");
        while (true)
        {
            string libro = Console.ReadLine();
            if (libro.ToLower() == "fin")
                break;
            librosPrestados.Add(libro);
        }

        Console.WriteLine("Ingrese títulos de libros reservados (escriba 'fin' para terminar):");
        while (true)
        {
            string libro = Console.ReadLine();
            if (libro.ToLower() == "fin")
                break;
            librosReservados.Add(libro);
        }

        // Libros tanto prestados como reservados
        HashSet<string> enAmbos = new HashSet<string>(librosPrestados);
        enAmbos.IntersectWith(librosReservados);

        // Todos los libros únicos
        HashSet<string> todosLibros = new HashSet<string>(librosPrestados);
        todosLibros.UnionWith(librosReservados);

        Console.WriteLine("\nResumen de títulos:");
        foreach (var libro in todosLibros)
        {
            if (librosPrestados.Contains(libro) && librosReservados.Contains(libro))
            {
                Console.WriteLine($"{libro}: Ambos");
            }
            else if (librosPrestados.Contains(libro))
            {
                Console.WriteLine($"{libro}: Prestado");
            }
            else
            {
                Console.WriteLine($"{libro}: Reservado");
            }
        }
    }
}
