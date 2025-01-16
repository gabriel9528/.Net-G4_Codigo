using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPizza.CreadorAbastracto;
using AbstractFactoryPizza.ProductoAbstracto;

namespace AbstractFactoryPizza.CreadorConcreto
{
    public class ArequipaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            return (Pizza)Activator.
                 CreateInstance(Type.GetType($"AbstractFactoryPizza.ProductoConcreto.Arequipa.Arequipa{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }

    }
}
