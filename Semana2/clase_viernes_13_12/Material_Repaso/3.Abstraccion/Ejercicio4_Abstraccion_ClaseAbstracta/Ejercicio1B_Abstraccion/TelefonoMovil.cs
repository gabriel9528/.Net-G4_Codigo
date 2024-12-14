using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1B_Abstraccion
{
    public class TelefonoMovil : Dispositivo
    {
        public TelefonoMovil(string marca, string modelo, int año) : base(marca, modelo, año) { }

        public override void Encender()
        {
            Console.WriteLine($"El teléfono móvil {Marca} {Modelo} del año {Año} se ha encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El teléfono móvil {Marca} {Modelo} del año {Año} se ha apagado.");
        }

        public override string ObtenerInfo()
        {
            return $"Teléfono Móvil: {Marca} {Modelo} ({Año})";
        }
    }
}
