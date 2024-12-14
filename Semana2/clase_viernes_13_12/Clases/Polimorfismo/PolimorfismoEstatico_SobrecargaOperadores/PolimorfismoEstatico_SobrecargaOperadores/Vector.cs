using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoEstatico_SobrecargaOperadores
{
    public class Vector
    {
        public double X {  get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator + (Vector vectorA, Vector vectorB)
        {

            return new Vector(vectorA.X + vectorB.X, vectorA.Y + vectorB.Y);
        }
    }
}
