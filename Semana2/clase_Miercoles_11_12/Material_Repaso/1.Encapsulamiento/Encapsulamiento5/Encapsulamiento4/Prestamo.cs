using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento4
{
    public class Prestamo
    {
        internal Usuario Usuario;
        private Libro Libro;
        protected internal DateTime FechaPrestamo;
        protected DateTime FechaDevolucion;

        public Prestamo(Usuario usuario, Libro libro, DateTime fechaPrestamo)
        {
            Usuario = usuario;
            Libro = libro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = DateTime.MinValue; // Indica que no ha sido devuelto aún
            Libro.SetDisponible(false);
            Usuario.AgregarLibro(libro);
        }

        public Usuario GetUsuario() => Usuario;
        public Libro GetLibro() => Libro;
        public DateTime GetFechaPrestamo() => FechaPrestamo;
        public DateTime GetFechaDevolucion() => FechaDevolucion;

        public void DevolverLibro(DateTime fechaDevolucion)
        {
            FechaDevolucion = fechaDevolucion;
            Libro.SetDisponible(true);
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Usuario: {Usuario.GetNombre()} {Usuario.GetApellido()}, Libro: {Libro.GetTitulo()}, Fecha de Préstamo: {FechaPrestamo}, Fecha de Devolución: {FechaDevolucion}");
        }
    }
}
