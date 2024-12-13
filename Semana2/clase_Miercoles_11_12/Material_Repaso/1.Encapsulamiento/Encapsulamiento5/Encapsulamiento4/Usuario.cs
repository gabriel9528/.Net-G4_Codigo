using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento4
{
    public class Usuario
    {
        private int ID;
        protected string Nombre;
        internal string Apellido;
        protected internal List<Libro> LibrosPrestados;

        public Usuario(int id, string nombre, string apellido)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            LibrosPrestados = new List<Libro>();
        }

        public int GetID() => ID;
        public string GetNombre() => Nombre;
        public string GetApellido() => Apellido;
        public List<Libro> GetLibrosPrestados() => LibrosPrestados;

        public void AgregarLibro(Libro libro)
        {
            if (!LibrosPrestados.Contains(libro))
            {
                LibrosPrestados.Add(libro);
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {ID}, Nombre: {Nombre} {Apellido}");
            Console.WriteLine("Libros Prestados:");
            foreach (var libro in LibrosPrestados)
            {
                libro.MostrarInfo();
            }
            Console.WriteLine("-----------------*----------");
        }
    }
}
