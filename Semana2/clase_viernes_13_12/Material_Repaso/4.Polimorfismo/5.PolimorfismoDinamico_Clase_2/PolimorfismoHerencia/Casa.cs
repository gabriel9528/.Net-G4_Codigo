using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHerencia
{
    public class Casa : Inmueble
    {
        //Estados - Atributos
        //...
        //Comportamientos - Métodos
        //...
        //Constructor
        public Casa(string tipo, double prec)
        {
            this.tipoInmueble = tipo;
            this.precio = prec;
        }

        // Sobrescribir el método vender
        public override void vender()
        {
            Console.WriteLine($"La {tipoInmueble} ha sido vendida con un descuento especial por {precio * 0.9:C}.");
        }
    }
}
