using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Before
{
    public class AreaCalculator
    {
        public string Area(List<object> shapes)
        {
            string area = "";
            foreach (var shape in shapes)
            {
                if (shape is Rectangulo)
                {
                    Rectangulo rectangulo = (Rectangulo)shape;
                    area += rectangulo.Width * rectangulo.Height;
                }
                else
                {
                    Circulo circulo = (Circulo)shape;
                    area += Math.PI * Math.Pow(circulo.Radius, 2);
                }

                area += Environment.NewLine;
            }

            return area;
        }
    }
}
