using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPizza.CreadorAbastracto;
using AbstractFactoryPizza.ProductoAbstracto;

namespace AbstractFactoryPizza.CreadorConcreto
{
    public class LimaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            return (Pizza)Activator.
                 CreateInstance(Type.GetType($"AbstractFactoryPizza.ProductoConcreto.Lima.Lima{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }

    }
}
