using AbstractFactoryPizza.FabricaAbstracta;
using AbstractFactoryPizza.ProductoAbstracto.Interfaces;
using AbstractFactoryPizza.ProductoConcreto.Lima;

namespace AbstractFactoryPizza.FabricasConcretas
{
    internal class LimaPizzaIngredientesFactory : IPizzaIngredientesFactory
    {
        public IMasa CrearMasa()
        {
            return new LimaMasa();
        }

        public IQueso CrearQueso()
        {
            return new LimaQueso();
        }

        public ISalsas CrearSalsas()
        {
            return new LimaSalsas();
        }

        public List<IVerduras> CrearVerduras()
        {
            return new List<IVerduras>
            {
            };
        }
    }
}
