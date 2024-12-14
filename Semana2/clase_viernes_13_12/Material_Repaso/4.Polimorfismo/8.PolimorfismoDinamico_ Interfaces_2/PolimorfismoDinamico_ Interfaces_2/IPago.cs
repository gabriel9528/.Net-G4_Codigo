using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoDinamico__Interfaces_2
{
    public interface IPago
    {
        void ProcesarPago(double monto);
        string GenerarRecibo();
    }
}
