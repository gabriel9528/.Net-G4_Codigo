using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.FabricaAbstracta
{
    public interface IPizzaIngredientesFactory
    {
        IMasa CrearMasa();
        ISalsas CrearSalsas();
        IQueso CrearQueso();
        List<IVerduras> CrearVerduras();

    }
}
