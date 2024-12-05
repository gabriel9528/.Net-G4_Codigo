using Listas_Ejercicio5;

public class Program
{
    public static void Main()
    {
        var biblioteca = new Biblioteca();

        // Añadir libros a la biblioteca
        biblioteca.AgregarLibro(new Libro("Cien Años de Soledad", "Gabriel García Márquez"));
        biblioteca.AgregarLibro(new Libro("Don Quijote de la Mancha", "Miguel de Cervantes"));
        biblioteca.AgregarLibro(new Libro("El Principito", "Antoine de Saint-Exupéry"));

        // Verificar si un libro está en la colección
        Console.WriteLine($"¿El Principito está en la colección? {biblioteca.EstaEnColeccion("El Principito")}");

        // Prestar un libro
        biblioteca.PrestarLibro("El Principito");

        // Intentar prestar el mismo libro nuevamente
        biblioteca.PrestarLibro("El Principito");

        // Devolver el libro
        biblioteca.DevolverLibro("El Principito");

        // Mostrar resumen de la biblioteca
        biblioteca.MostrarResumen();
    }
}