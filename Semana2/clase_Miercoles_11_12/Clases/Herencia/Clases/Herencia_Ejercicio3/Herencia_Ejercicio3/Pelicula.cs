using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio3
{
    internal class Pelicula : MaterialBibliografico
    {
        public string Director { get; set; }
        public int Duracion { get; set; }

        public override void MostrarPublicacion()
        {
            base.MostrarPublicacion();
            Console.WriteLine("Director: " + Director);
            Console.WriteLine("Duracion: " + Duracion + " en minutos.");
        }
    }
}
