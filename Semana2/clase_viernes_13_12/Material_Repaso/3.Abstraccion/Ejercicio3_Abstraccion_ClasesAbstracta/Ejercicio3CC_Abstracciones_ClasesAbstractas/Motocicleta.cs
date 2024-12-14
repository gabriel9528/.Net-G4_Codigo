using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CC_Abstracciones_ClasesAbstractas
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void Iniciar()
        {
            Console.WriteLine($"La motocicleta {Marca} {Modelo} se ha iniciado.");
        }

        public override void Detener()
        {
            Console.WriteLine($"La motocicleta {Marca} {Modelo} se ha detenido.");
        }

        public override string ObtenerDetalles()
        {
            return $"Motocicleta: {Marca} {Modelo}";
        }
    }
}
