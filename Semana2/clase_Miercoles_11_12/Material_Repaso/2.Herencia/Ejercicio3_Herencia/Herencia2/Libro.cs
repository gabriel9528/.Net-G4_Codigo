using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    public class Libro : MaterialBibliografico
    {
        public string ISBN { get; set; }
        public int NumeroPaginas { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Número de páginas: " + NumeroPaginas);
        }
    }
}
