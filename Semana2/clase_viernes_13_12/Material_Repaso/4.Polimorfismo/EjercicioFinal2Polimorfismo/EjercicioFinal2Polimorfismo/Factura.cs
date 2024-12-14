using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal2Polimorfismo
{
    public class Factura : DocumentoFiscal
    {
        public string Detalle { get; set; }

        public Factura(string numero, DateTime fecha, double monto, string detalle)
            : base(numero, fecha, monto)
        {
            Detalle = detalle;
        }

        public override double CalcularTotal()
        {
            return Monto;
        }
    }
}
