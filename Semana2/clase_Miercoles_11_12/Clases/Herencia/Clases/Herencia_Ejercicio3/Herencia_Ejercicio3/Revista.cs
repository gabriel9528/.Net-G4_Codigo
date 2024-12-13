using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio3
{
    internal class Revista : MaterialBibliografico
    {
        public string ISSN { get; set; }
        public int NumeroVolumen { get; set; }

        public override void MostrarPublicacion()
        {
            base.MostrarPublicacion();
            Console.WriteLine("ISSN: " + ISSN);
            Console.WriteLine("NumeroVolumen: " + NumeroVolumen);
        }
    }
}
