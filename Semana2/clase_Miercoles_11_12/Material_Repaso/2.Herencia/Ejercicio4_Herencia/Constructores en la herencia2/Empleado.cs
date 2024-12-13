using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_en_la_herencia2
{
    public class Empleado
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
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Salario: " + Salario);
        }
    }
}
