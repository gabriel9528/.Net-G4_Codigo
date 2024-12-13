using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacion { get; set; }
        public int NumRuedas { get; set; }

        // Constructor
        public Vehiculo(string marca, string modelo, int anoFabricacion, int numRuedas)
        {
            Marca = marca;
            Modelo = modelo;
            AnoFabricacion = anoFabricacion;
            NumRuedas = numRuedas;
        }

        // Método para calcular el consumo de combustible (por defecto 10 litros cada 100 km)
        public virtual double CalcularConsumoCombustible(double distancia)
        {
            return (distancia / 100) * 10; // Suponiendo 10 litros cada 100 km
        }

        // Método para mostrar información general del vehículo
        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {AnoFabricacion}, Número de Ruedas: {NumRuedas}");
        }
    }
}
