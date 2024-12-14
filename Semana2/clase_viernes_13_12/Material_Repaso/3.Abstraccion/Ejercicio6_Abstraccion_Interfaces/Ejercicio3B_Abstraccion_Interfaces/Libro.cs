using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3B_Abstraccion_Interfaces
{
    public class Libro : IPublicacion
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }

        public Libro(string titulo, string autor, int añoPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
        }

        public void Publicar()
        {
            Console.WriteLine($"El libro '{Titulo}' por {Autor} ha sido publicado en el año {AñoPublicacion}.");
        }

        public string ObtenerDetalles()
        {
            return $"Libro: '{Titulo}' por {Autor}, publicado en {AñoPublicacion}.";
        }

        public string VerificarTipo()
        {
            return "Tipo de publicación: Libro";
        }
    }
}
