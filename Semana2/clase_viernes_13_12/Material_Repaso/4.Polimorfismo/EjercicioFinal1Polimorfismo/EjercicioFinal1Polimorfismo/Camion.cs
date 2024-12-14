using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal1Polimorfismo
{
    public class Camion : Vehiculo
    {
        public double CapacidadCarga { get; set; } // En toneladas

        public Camion(string matricula, string modelo, double tarifaDiaria, double capacidadCarga)
            : base(matricula, modelo, tarifaDiaria)
        {
            CapacidadCarga = capacidadCarga;
        }

        public override double CalcularTarifa()
        {
            double recargo = CapacidadCarga > 10 ? 0.20 : 0;
            return TarifaDiaria * (1 + recargo);
        }
    }
}
