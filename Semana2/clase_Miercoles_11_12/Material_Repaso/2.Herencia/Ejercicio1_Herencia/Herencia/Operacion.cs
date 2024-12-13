using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Supongamos que necesitamos implementar dos clases que llamaremos Suma y Resta.
//Cada clase tiene como atributo valor1, valor2 y resultado. Las propiedades a
//definir son Valor1, Valor2 y Resultado, el método Operar (que en el caso de
//la clase "Suma" suma los dos Valores y en el caso de la clase "Resta" hace la
//diferencia entre Valor1 y Valor2.

namespace Herencia
{
    public class Operacion
    {
        private int valor1;
        private int valor2;
        private int resultado;

        internal int Valor1
        {
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }

        internal int Valor2
        {
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2;
            }
        }

        internal int Resultado
        {
            set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
    }
}
