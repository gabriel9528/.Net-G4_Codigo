using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1B_Abstraccion
{
    public abstract class Dispositivo
    {
        // Propiedades comunes a todos los dispositivos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        // Constructor
        public Dispositivo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        // Métodos abstractos
        public abstract void Encender();
        public abstract void Apagar();
        public abstract string ObtenerInfo();
    }
}
