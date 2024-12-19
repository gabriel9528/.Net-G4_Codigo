using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2__After_ISP
{
    internal class Car : IVehicle, IEngineVehicle
    {
        public int GetNumberOfWheels()
        {
            return 4;
        }

        public void Move()
        {
            Console.WriteLine("Carro moviendose");
        }

        public void StarEngine()
        {
            Console.WriteLine("Carro encendido");
        }

        public void StopEngine()
        {
            Console.WriteLine("Carro apagado");
        }
    }
}
