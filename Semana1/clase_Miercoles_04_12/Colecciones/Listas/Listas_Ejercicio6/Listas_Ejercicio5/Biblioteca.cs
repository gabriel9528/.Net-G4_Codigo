using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Ejercicio5
{
    public class Biblioteca
    {
        private List<Libro> libros;

        public Biblioteca()
        {
            libros = new List<Libro>();
        }

        // Método para añadir un libro a la biblioteca
        public void AgregarLibro(Libro libro)
        {
            if (!libros.Contains(libro))
            {
                libros.Add(libro);
                Console.WriteLine($"Libro '{libro.Titulo}' agregado a la biblioteca.");
            }
            else
            {
                Console.WriteLine($"El libro '{libro.Titulo}' ya está en la biblioteca.");
            }
        }

        // Método para verificar si un libro está en la colección
        public bool EstaEnColeccion(string titulo)
        {
            return libros.Any(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        // Método para prestar un libro
        public void PrestarLibro(string titulo)
        {
            var libro = libros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro != null)
            {
                if (!libro.Prestado)
                {
                    libro.Prestado = true;
                    Console.WriteLine($"El libro '{titulo}' ha sido prestado.");
                }
                else
                {
                    Console.WriteLine($"El libro '{titulo}' ya está prestado.");
                }
            }
            else
            {
                Console.WriteLine($"El libro '{titulo}' no se encuentra en la biblioteca.");
            }
        }

        // Método para devolver un libro
        public void DevolverLibro(string titulo)
        {
            var libro = libros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro != null)
            {
                if (libro.Prestado)
                {
                    libro.Prestado = false;
                    Console.WriteLine($"El libro '{titulo}' ha sido devuelto.");
                }
                else
                {
                    Console.WriteLine($"El libro '{titulo}' no estaba prestado.");
                }
            }
            else
            {
                Console.WriteLine($"El libro '{titulo}' no se encuentra en la biblioteca.");
            }
        }

        // Método para mostrar la cantidad de libros y el número de libros prestados
        public void MostrarResumen()
        {
            int totalLibros = libros.Count;
            int librosPrestados = libros.Count(l => l.Prestado);
            Console.WriteLine($"Total de libros en la biblioteca: {totalLibros}");
            Console.WriteLine($"Libros prestados: {librosPrestados}");
        }
    }
}
