using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal2Polimorfismo
{
    public class NotaDebito : DocumentoFiscal
    {
        public double MontoRecargo { get; set; }

        public NotaDebito(string numero, DateTime fecha, double monto, double montoRecargo)
            : base(numero, fecha, monto)
        {
            MontoRecargo = montoRecargo;
        }

        public override double CalcularTotal()
        {
            return Monto + MontoRecargo;
        }
    }
}
