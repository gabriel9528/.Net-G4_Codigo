using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal2Polimorfismo
{
    public abstract class DocumentoFiscal
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }

        public DocumentoFiscal(string numero, DateTime fecha, double monto)
        {
            Numero = numero;
            Fecha = fecha;
            Monto = monto;
        }

        public abstract double CalcularTotal();
    }
}
