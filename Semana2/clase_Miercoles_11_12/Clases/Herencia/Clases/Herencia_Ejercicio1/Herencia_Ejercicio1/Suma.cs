using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio1
{
    internal class Suma : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 + Valor2;
        }
    }
}
