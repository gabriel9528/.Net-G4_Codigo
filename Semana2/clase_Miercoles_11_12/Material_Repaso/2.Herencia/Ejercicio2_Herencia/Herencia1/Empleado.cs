using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    public class Empleado : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }
}
