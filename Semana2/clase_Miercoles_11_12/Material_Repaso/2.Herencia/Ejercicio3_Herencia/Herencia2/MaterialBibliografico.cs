using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Herencia2
{
    public class MaterialBibliografico
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Año de publicación: " + AñoPublicacion);
        }
    }
}
