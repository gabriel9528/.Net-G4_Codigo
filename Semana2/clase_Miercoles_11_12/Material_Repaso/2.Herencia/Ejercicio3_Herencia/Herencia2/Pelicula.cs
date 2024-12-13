using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    public class Pelicula : MaterialBibliografico
    {
        public string Director { get; set; }
        public int Duracion { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Director: " + Director);
            Console.WriteLine("Duración: " + Duracion + " minutos");
        }
    }
}
