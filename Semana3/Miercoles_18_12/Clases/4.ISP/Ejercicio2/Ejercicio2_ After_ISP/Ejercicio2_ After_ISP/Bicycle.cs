using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2__After_ISP
{
    internal class Bicycle : IVehicle
    {
        public int GetNumberOfWheels()
        {
            return 2;
        }

        public void Move()
        {
            Console.WriteLine("Bicileta moviendose"); ;
        }
    }
}
