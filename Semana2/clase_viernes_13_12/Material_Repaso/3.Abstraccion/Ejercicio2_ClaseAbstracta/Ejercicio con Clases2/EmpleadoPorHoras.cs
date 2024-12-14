using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_con_Clases2
{
    public class EmpleadoPorHoras : Empleado
    {
        public decimal PagoPorHora { get; set; }
        public int HorasTrabajadasPorMes { get; set; }

        public override decimal CalcularSalarioAnual()
        {
            return PagoPorHora * HorasTrabajadasPorMes * 12;
        }

        public override string ToString()
        {
            return base.ToString() + $", Pago por Hora: {PagoPorHora}, Horas Trabajadas por Mes: {HorasTrabajadasPorMes}";
        }
    }
}
