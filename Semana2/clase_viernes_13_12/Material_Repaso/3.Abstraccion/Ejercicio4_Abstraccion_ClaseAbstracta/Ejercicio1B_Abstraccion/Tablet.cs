using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1B_Abstraccion
{
    public class Tablet : Dispositivo
    {
        public Tablet(string marca, string modelo, int año) : base(marca, modelo, año) { }

        public override void Encender()
        {
            Console.WriteLine($"La tablet {Marca} {Modelo} del año {Año} se ha encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"La tablet {Marca} {Modelo} del año {Año} se ha apagado.");
        }

        public override string ObtenerInfo()
        {
            return $"Tablet: {Marca} {Modelo} ({Año})";
        }
    }
}
