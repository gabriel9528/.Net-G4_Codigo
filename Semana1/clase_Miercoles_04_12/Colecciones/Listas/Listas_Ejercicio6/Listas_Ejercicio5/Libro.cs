using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Ejercicio5
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Prestado { get; set; }

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Prestado = false; // Por defecto, el libro no está prestado
        }
    }
}
