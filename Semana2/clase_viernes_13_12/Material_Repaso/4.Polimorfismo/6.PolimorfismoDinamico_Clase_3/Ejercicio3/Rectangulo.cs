using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Rectangulo : Forma
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public override double Area()
        {
            return Ancho * Alto;
        }

        public override double Perimetro()
        {
            return 2 * (Ancho + Alto);
        }
    }

}
