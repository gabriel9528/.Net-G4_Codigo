using Herencia_Ejercicio3;

class Program
{
    static void Main()
    {
        Libro libro = new Libro()
        {
            Titulo = "Cien años de soledad",
            Autor = "Gabriel Garcia Marquez",
            FechaPublicacion = 1990,
            ISBN = "159-362",
            NumeroPaginas = 500
        };

        Revista revista = new Revista()
        {
            Titulo = "National Geographic",
            Autor = "National Geographic - SAC",
            FechaPublicacion = 2020,
            ISSN = "4896-3215",
            NumeroVolumen = 50
        };

        Pelicula Pelicula = new Pelicula()
        {
            Titulo = "El Padrino",
            Autor = "Autor el Padrino",
            FechaPublicacion = 1990,
            Director = "Gabriel Manrique",
            Duracion = 180
        };

        Console.WriteLine("Informacion del libro: ");
        libro.MostrarPublicacion();

        Console.WriteLine("***********************************************************");

        Console.WriteLine("Informacion de la Revista: ");
        revista.MostrarPublicacion();

        Console.WriteLine("***********************************************************");

        Console.WriteLine("Informacion de la Pelicula: ");
        Pelicula.MostrarPublicacion();
    }
}