using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHerencia
{
    public class Terreno : Inmueble
    {
        //Estados - Atributos
        //...
        //Comportamientos - Métodos 
        //... 
        //Constructor
        public Terreno(string tipo, double prec)
        {
            this.tipoInmueble = tipo;
            this.precio = prec;
        }

        // Sobrescribir el método vender
        public override void vender()
        {
            Console.WriteLine($"El {tipoInmueble} se vendió para construcción por {precio:C}.");
        }
    }
}
