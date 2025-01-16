using AbstractFactoryPizza.ProductoAbstracto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPizza.ProductoConcreto.Lima
{
    internal class LimaQueso : IQueso
    {
        public void QuesoParmesano()
        {
            Console.WriteLine("Agregando queso parmesano - Lima " + Environment.NewLine);
        }
    }
}
