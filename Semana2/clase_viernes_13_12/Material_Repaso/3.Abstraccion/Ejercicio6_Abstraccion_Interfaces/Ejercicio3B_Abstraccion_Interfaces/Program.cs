

using Ejercicio3B_Abstraccion_Interfaces;

class Program
{
    static void Main()
    {
        // Crear instancias de cada tipo de publicación
        IPublicacion libro = new Libro("El Quijote", "Miguel de Cervantes", 1605);
        IPublicacion articulo = new Articulo("Relatividad General", "Albert Einstein", "Annalen der Physik");
        IPublicacion blog = new Blog("Tecnologías Emergentes", "John Doe", "www.techblog.com");

        // Coleccion de publicaciones
        List<IPublicacion> publicaciones = new List<IPublicacion>
        {
            libro,
            articulo,
            blog
        };

        // Publicar, obtener detalles y verificar tipo de cada publicación
        foreach (IPublicacion publicacion in publicaciones)
        {
            publicacion.Publicar();
            Console.WriteLine(publicacion.ObtenerDetalles());
            Console.WriteLine(publicacion.VerificarTipo());
            Console.WriteLine();
        }
    }
}