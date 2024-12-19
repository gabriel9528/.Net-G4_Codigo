using System;
using System.Collections.Generic;
using System.Text;

namespace ISPLibrary
{
    public class Car : IVehicle
    {
        public int GetNumberOfWheel()
        {
            return 4;
        }

        public void Move()
        {
            Console.WriteLine("Moviendo");
        }

        int IVehicle.startEngine()
        {
            return 100;
        }

        int IVehicle.stopEngine()
        {
            return 200;
        }
    }
}
