using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    public class Revista : MaterialBibliografico
    {
        public string ISSN { get; set; }
        public int NumeroVolumen { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("ISSN: " + ISSN);
            Console.WriteLine("Número de volumen: " + NumeroVolumen);
        }
    }
}
