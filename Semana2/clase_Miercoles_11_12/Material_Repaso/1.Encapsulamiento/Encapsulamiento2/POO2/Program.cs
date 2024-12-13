using POO2;
using System;

namespace Program
{
    public class Ejercicio_POO_DDR_1
    {
        public static void Main(string[] args)
        {
            // Creamos los objetos
            Libro libro1 = new Libro(1111111111, "titulo1", "autor1", 30);
            Libro libro2 = new Libro(1111111112, "titulo2", "autor2", 60);

            // Mostramos su estado
            Console.WriteLine(libro1.ToString());
            Console.WriteLine(libro2.ToString());

            // Modificamos el atributo numPaginas del libro1
            libro1.NumPaginasPropiedad = 70;

            // Comparamos quien tiene mas paginas
            if (libro1.NumPaginasPropiedad > libro2.NumPaginasPropiedad)
            {
                Console.WriteLine(libro1.TituloPropiedad + " tiene más páginas");
            }
            else
            {
                Console.WriteLine(libro2.TituloPropiedad + " tiene más páginas");
            }
        }
    }
}
