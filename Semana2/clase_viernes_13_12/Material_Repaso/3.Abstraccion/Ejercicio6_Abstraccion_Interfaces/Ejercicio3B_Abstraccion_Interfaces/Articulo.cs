using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3B_Abstraccion_Interfaces
{
    public class Articulo : IPublicacion
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Revista { get; set; }

        public Articulo(string titulo, string autor, string revista)
        {
            Titulo = titulo;
            Autor = autor;
            Revista = revista;
        }

        public void Publicar()
        {
            Console.WriteLine($"El artículo '{Titulo}' por {Autor} ha sido publicado en la revista {Revista}.");
        }

        public string ObtenerDetalles()
        {
            return $"Artículo: '{Titulo}' por {Autor}, publicado en {Revista}.";
        }

        public string VerificarTipo()
        {
            return "Tipo de publicación: Artículo";
        }
    }
}
