using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Structure
{
    struct Rectangulo
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public double CalcularArea()
        {
            return Ancho * Alto;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Ancho + Alto);
        }
    }
}
