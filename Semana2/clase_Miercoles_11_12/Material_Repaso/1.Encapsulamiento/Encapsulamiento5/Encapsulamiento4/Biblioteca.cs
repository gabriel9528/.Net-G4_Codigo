using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento4
{
    public class Biblioteca
    {
        private List<Libro> ListaLibros;
        protected List<Usuario> ListaUsuarios;
        internal List<Prestamo> ListaPrestamos;

        public Biblioteca()
        {
            ListaLibros = new List<Libro>();
            ListaUsuarios = new List<Usuario>();
            ListaPrestamos = new List<Prestamo>();
        }

        public void AgregarLibro(Libro libro) => ListaLibros.Add(libro);
        public void AgregarUsuario(Usuario usuario) => ListaUsuarios.Add(usuario);

        public void RegistrarPrestamo(Usuario usuario, Libro libro)
        {
            if (libro.Disponible)
            {
                Prestamo prestamo = new Prestamo(usuario, libro, DateTime.Now);
                ListaPrestamos.Add(prestamo);
            }
            else
            {
                Console.WriteLine("El libro no está disponible.");
            }
        }

        public void DevolverLibro(Usuario usuario, Libro libro)
        {
            var prestamo = ListaPrestamos.Find(p => p.GetUsuario() == usuario && p.GetLibro() == libro && p.GetFechaDevolucion() == DateTime.MinValue);
            if (prestamo != null)
            {
                prestamo.DevolverLibro(DateTime.Now);
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Libros en la Biblioteca:");
            foreach (var libro in ListaLibros)
            {
                libro.MostrarInfo();
            }
            Console.WriteLine("\nUsuarios de la Biblioteca:");
            foreach (var usuario in ListaUsuarios)
            {
                usuario.MostrarInfo();
            }
            Console.WriteLine("\nPréstamos:");
            foreach (var prestamo in ListaPrestamos)
            {
                prestamo.MostrarInfo();
            }
        }
    }
}
