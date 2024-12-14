using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal2Polimorfismo
{
    public class NotaCredito : DocumentoFiscal
    {
        public double MontoDescuento { get; set; }

        public NotaCredito(string numero, DateTime fecha, double monto, double montoDescuento)
            : base(numero, fecha, monto)
        {
            MontoDescuento = montoDescuento;
        }

        public override double CalcularTotal()
        {
            return Monto - MontoDescuento;
        }
    }
}
