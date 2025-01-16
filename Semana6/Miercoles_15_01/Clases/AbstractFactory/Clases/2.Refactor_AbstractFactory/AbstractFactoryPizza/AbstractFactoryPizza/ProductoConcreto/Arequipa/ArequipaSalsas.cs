using AbstractFactoryPizza.ProductoAbstracto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPizza.ProductoConcreto.Arequipa
{
    internal class ArequipaSalsas : ISalsas
    {
        public void SalsaMarinada()
        {
            Console.WriteLine("Agregando salsa marinada - Arequipa " + Environment.NewLine);
        }
    }
}
