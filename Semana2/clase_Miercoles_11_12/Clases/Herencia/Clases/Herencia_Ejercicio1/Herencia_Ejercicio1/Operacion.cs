using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio1
{
    internal class Operacion
    {
        private int _valor1;
        private int _valor2;
        private int _resultado;

        public int Valor1
        {
            get { return _valor1; }
            set { _valor1 = value; }
        }

        public int Valor2
        {
            get { return _valor2; }
            set { _valor2 = value; }
        }

        public int Resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }
    }
}
