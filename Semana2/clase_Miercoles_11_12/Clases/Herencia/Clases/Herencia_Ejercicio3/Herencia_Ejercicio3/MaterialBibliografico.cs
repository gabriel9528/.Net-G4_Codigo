using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio3
{
    internal class MaterialBibliografico
    {
        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public int FechaPublicacion {  get; set; }

        public virtual void MostrarPublicacion()
        {
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("FechaPublicacion: " + FechaPublicacion);
        }
    }
}
