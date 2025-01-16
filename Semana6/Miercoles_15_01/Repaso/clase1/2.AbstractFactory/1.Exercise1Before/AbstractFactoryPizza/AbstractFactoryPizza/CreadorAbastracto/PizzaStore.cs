using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPizza.ProductoAbstracto;

namespace AbstractFactoryPizza.CreadorAbastracto
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(TypeOfPizza type);

        public Pizza OrderPizza(TypeOfPizza type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Cocinar();
            pizza.Cortar();
            pizza.Encajar();

            return pizza;

        }
    }

}
