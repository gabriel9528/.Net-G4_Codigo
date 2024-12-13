using Encapsulamiento4;

public class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        Libro libro1 = new Libro(1, "El Quijote", "Miguel de Cervantes", "Novela", true);
        Libro libro2 = new Libro(2, "Cien Años de Soledad", "Gabriel García Márquez", "Realismo Mágico", true);

        Usuario usuario1 = new Usuario(1, "Gabriel", "Retamozo");
        Usuario usuario2 = new Usuario(2, "María", "López");

        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);

        biblioteca.AgregarUsuario(usuario1);
        biblioteca.AgregarUsuario(usuario2);

        biblioteca.RegistrarPrestamo(usuario1, libro1);
        biblioteca.DevolverLibro(usuario1, libro1);

        biblioteca.MostrarInfo();
    }
}