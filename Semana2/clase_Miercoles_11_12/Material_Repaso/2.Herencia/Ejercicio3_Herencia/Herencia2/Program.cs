using Herencia2;

class Program
{
    static void Main(string[] args)
    {
        Libro libro = new Libro
        {
            Titulo = "Cien años de soledad",
            Autor = "Gabriel García Márquez",
            AñoPublicacion = 1967,
            ISBN = "978-0307474728",
            NumeroPaginas = 432
        };

        Revista revista = new Revista
        {
            Titulo = "National Geographic",
            Autor = "National Geographic Society",
            AñoPublicacion = 2021,
            ISSN = "0027-9358",
            NumeroVolumen = 239
        };

        Pelicula pelicula = new Pelicula
        {
            Titulo = "El Padrino",
            Autor = "Francis Ford Coppola",
            AñoPublicacion = 1972,
            Director = "Francis Ford Coppola",
            Duracion = 175
        };

        Console.WriteLine("Información del libro:");
        libro.MostrarInformacion();
        Console.WriteLine();

        Console.WriteLine("Información de la revista:");
        revista.MostrarInformacion();
        Console.WriteLine();

        Console.WriteLine("Información de la película:");
        pelicula.MostrarInformacion();
    }
}