using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento4
{
    public class Libro
    {
        private int ID;
        protected string Titulo;
        internal string Autor;
        protected internal string Genero;
        public bool Disponible { get; private set; }

        public Libro(int id, string titulo, string autor, string genero, bool disponible)
        {
            ID = id;
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            Disponible = disponible;
        }

        public int GetID() => ID;
        public string GetTitulo() => Titulo;
        public string GetAutor() => Autor;
        public string GetGenero() => Genero;
        public void SetDisponible(bool disponible) => Disponible = disponible;

        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {ID}, Título: {Titulo}, Autor: {Autor}, Género: {Genero}, Disponible: {Disponible}");
        }
    }

}
