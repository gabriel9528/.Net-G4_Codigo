using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal1Polimorfismo
{
    public class Moto : Vehiculo
    {
        public string TipoMotor { get; set; } // "Electrico" o "Gasolina"

        public Moto(string matricula, string modelo, double tarifaDiaria, string tipoMotor)
            : base(matricula, modelo, tarifaDiaria)
        {
            TipoMotor = tipoMotor;
        }

        public override double CalcularTarifa()
        {
            double recargo = TipoMotor == "Gasolina" ? 0.05 : 0;
            return TarifaDiaria * (1 + recargo);
        }
    }
}
