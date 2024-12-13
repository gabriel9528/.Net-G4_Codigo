using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio3
{
    internal class Libro : MaterialBibliografico
    {
        public string ISBN { get; set; }
        public int NumeroPaginas { get; set; }

        public override void MostrarPublicacion()
        {
            base.MostrarPublicacion();
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Numero de paginas: " + NumeroPaginas);
        }
    }
}
