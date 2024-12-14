using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3B_Abstraccion_Interfaces
{
    public class Blog : IPublicacion
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string URL { get; set; }

        public Blog(string titulo, string autor, string url)
        {
            Titulo = titulo;
            Autor = autor;
            URL = url;
        }

        public void Publicar()
        {
            Console.WriteLine($"El blog '{Titulo}' por {Autor} ha sido publicado en {URL}.");
        }

        public string ObtenerDetalles()
        {
            return $"Blog: '{Titulo}' por {Autor}, publicado en {URL}.";
        }

        public string VerificarTipo()
        {
            return "Tipo de publicación: Blog";
        }
    }

}
