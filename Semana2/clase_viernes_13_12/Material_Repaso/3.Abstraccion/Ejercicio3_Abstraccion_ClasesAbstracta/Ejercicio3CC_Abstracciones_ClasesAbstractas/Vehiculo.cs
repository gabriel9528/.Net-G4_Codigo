using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CC_Abstracciones_ClasesAbstractas
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // Constructor
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        // Método abstracto para iniciar el vehículo
        public abstract void Iniciar();

        // Método abstracto para detener el vehículo
        public abstract void Detener();

        // Método abstracto para obtener detalles del vehículo
        public abstract string ObtenerDetalles();
    }
}
