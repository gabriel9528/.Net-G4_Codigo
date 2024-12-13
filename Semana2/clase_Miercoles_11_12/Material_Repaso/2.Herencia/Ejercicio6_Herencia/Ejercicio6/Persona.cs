using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor
        public Persona(int id, string nombre, int edad)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
        }

        // Método para mostrar información
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
