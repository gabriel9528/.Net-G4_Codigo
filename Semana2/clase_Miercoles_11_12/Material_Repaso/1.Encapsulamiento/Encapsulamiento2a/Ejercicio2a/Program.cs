using Ejercicio2a;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Crear dos objetos Pelicula
            Pelicula pelicula1 = new Pelicula
            {
                Codigo = "P001",
                Titulo = "El Gran Escape",
                Director = "John Sturges",
                Duracion = 172
            };

            Pelicula pelicula2 = new Pelicula
            {
                Codigo = "P002",
                Titulo = "Inception",
                Director = "Christopher Nolan",
                Duracion = 148
            };

            // Mostrar información de las películas
            Console.WriteLine(pelicula1.ToString());
            Console.WriteLine(pelicula2.ToString());

            // Comparar duraciones
            if (pelicula1.Duracion > pelicula2.Duracion)
            {
                Console.WriteLine($"\nLa película \"{pelicula1.Titulo}\" tiene mayor duración que \"{pelicula2.Titulo}\".");
            }
            else if (pelicula1.Duracion < pelicula2.Duracion)
            {
                Console.WriteLine($"\nLa película \"{pelicula2.Titulo}\" tiene mayor duración que \"{pelicula1.Titulo}\".");
            }
            else
            {
                Console.WriteLine($"\nAmbas películas tienen la misma duración.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}