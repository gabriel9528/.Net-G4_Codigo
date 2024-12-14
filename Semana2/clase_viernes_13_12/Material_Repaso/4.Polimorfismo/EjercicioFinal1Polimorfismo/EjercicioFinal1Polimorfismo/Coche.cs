using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal1Polimorfismo
{
    public class Coche : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public Coche(string matricula, string modelo, double tarifaDiaria, int numeroPuertas)
            : base(matricula, modelo, tarifaDiaria)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override double CalcularTarifa()
        {
            double recargo = NumeroPuertas > 4 ? 0.10 : 0;
            return TarifaDiaria * (1 + recargo);
        }
    }
}
