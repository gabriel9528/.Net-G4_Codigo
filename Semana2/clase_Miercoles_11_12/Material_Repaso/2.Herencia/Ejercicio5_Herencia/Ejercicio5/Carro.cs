using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Carro : Vehiculo
    {
        public int NumPuertas { get; set; }

        // Constructor que llama al constructor de la clase base
        public Carro(string marca, string modelo, int anoFabricacion, int numRuedas, int numPuertas)
            : base(marca, modelo, anoFabricacion, numRuedas)
        {
            NumPuertas = numPuertas;
        }

        // Sobrescritura del método CalcularConsumoCombustible
        public override double CalcularConsumoCombustible(double distancia)
        {
            // Los carros tienen un consumo más eficiente, por lo que multiplicamos por 8 en lugar de 10
            return (distancia / 100) * 8; // Suponiendo 8 litros cada 100 km
        }

        // Método para mostrar la información del carro
        public new void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Puertas: {NumPuertas}");
        }
    }
}
