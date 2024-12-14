using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHerencia
{
    public class Inmueble
    {
        //Estados - Atributos
        protected string tipoInmueble;
        protected string ubicacion;
        protected double areaTerreno;
        protected double precio;


        // Método virtual para permitir sobrescritura
        public virtual void vender()
        {
            Console.WriteLine($"El {tipoInmueble} se ha vendido por {precio:C}.");
        }
    }
}
