using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseTriangulo, double altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }

        public override double Area()
        {
            return 0.5 * Base * Altura;
        }

        public override double Perimetro()
        {
            // No se puede calcular el perímetro sin conocer los otros dos lados del triángulo.
            // Podría agregarse en un constructor si se conoce la longitud de los tres lados.
            throw new NotImplementedException();
        }
    }
}
