using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta_Ejercicio3
{
    internal class Coche : Vehiculo
    {
        public Coche(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void Detener()
        {
            Console.WriteLine($"El coche de marca {Marca} y {Modelo} se detuvo");
        }

        public override void Iniciar()
        {
            Console.WriteLine($"El coche de marca {Marca} y {Modelo} ha iniciado su marcha");
        }

        public override void ObtenerDetalles()
        {
            Console.WriteLine($"Coche de marca {Marca} y {Modelo}");
        }
    }
}
