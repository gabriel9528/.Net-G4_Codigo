using Abstract.FabricaAbstracta;
using Abstract.ProdctoConcreto.Lima;
using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.FabricaConcreta
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
