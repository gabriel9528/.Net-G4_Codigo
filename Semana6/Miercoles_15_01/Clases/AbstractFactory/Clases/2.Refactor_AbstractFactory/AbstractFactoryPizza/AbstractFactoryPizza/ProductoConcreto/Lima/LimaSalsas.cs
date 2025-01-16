using AbstractFactoryPizza.ProductoAbstracto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPizza.ProductoConcreto.Lima
{
    internal class LimaSalsas : ISalsas
    {
        public void SalsaMarinada()
        {
            Console.WriteLine("Agregando salsa marinada - Lima " + Environment.NewLine);
        }
    }
}
