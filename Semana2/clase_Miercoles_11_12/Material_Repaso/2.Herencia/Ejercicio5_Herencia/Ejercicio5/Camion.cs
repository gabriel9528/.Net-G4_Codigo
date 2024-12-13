using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Camion : Vehiculo
    {
        public double CapacidadCarga { get; set; }

        // Constructor que llama al constructor de la clase base
        public Camion(string marca, string modelo, int anoFabricacion, int numRuedas, double capacidadCarga)
            : base(marca, modelo, anoFabricacion, numRuedas)
        {
            CapacidadCarga = capacidadCarga;
        }

        // Sobrescritura del método CalcularConsumoCombustible
        public override double CalcularConsumoCombustible(double distancia)
        {
            // Los camiones tienen un consumo más alto, por lo que multiplicamos por 15 en lugar de 10
            return (distancia / 100) * 15; // Suponiendo 15 litros cada 100 km
        }

        // Método para mostrar la información del camión
        public new void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Capacidad de Carga: {CapacidadCarga} toneladas");
        }
    }
}
