using AbstractFactoryPizza.FabricaAbstracta;
using AbstractFactoryPizza.ProductoAbstracto.Interfaces;
using AbstractFactoryPizza.ProductoConcreto.Arequipa;

namespace AbstractFactoryPizza.FabricasConcretas
{
    internal class ArequipaPizzaIngredientesFactory : IPizzaIngredientesFactory
    {
        public IMasa CrearMasa()
        {
            return new ArequipaMasa();
        }

        public IQueso CrearQueso()
        {
            return new ArequipaQueso();
        }

        public ISalsas CrearSalsas()
        {
            return new ArequipaSalsas();
        }

        public List<IVerduras> CrearVerduras()
        {
            return new List<IVerduras>
            {
            };
        }
    }
}
