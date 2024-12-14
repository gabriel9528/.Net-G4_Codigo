using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CC_Abstracciones_ClasesAbstractas
{
    public class Camion : Vehiculo
    {
        public Camion(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void Iniciar()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} se ha iniciado.");
        }

        public override void Detener()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} se ha detenido.");
        }

        public override string ObtenerDetalles()
        {
            return $"Camión: {Marca} {Modelo}";
        }
    }
}
