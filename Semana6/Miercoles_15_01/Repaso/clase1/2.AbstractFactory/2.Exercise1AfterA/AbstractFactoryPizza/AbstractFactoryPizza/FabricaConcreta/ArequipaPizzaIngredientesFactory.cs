using Abstract.FabricaAbstracta;
using Abstract.ProdctoConcreto.Arequipa;
using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.FabricaConcreta
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
