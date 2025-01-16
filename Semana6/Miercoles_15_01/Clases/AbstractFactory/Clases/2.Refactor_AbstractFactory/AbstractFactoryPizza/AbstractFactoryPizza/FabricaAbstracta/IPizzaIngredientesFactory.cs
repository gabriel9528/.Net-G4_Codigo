using AbstractFactoryPizza.ProductoAbstracto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPizza.FabricaAbstracta
{
    internal interface IPizzaIngredientesFactory
    {
        IMasa CrearMasa();
        ISalsas CrearSalsas();
        IQueso CrearQueso();
        List<IVerduras> CrearVerduras();
    }
}
