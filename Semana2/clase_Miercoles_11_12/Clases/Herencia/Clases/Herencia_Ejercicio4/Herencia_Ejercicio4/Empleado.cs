using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio4
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, int edad, decimal salario)
        {
            Nombre = nombre;
            Edad = edad;
            Salario = salario;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad:: " + Edad);
            Console.WriteLine("Salario: " + Salario);
        }

        public virtual void MostrarInformacion2()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad:: " + Edad);
            Console.WriteLine("Salario: " + Salario);
        }

    }
}
