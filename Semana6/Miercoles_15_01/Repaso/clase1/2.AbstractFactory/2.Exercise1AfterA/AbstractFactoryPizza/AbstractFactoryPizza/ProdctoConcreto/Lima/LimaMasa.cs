using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.ProdctoConcreto.Lima
{
    internal class LimaMasa : IMasa
    {
        public void MasaDelgada()
        {
            Console.WriteLine("Agregando masa delgada - Lima " + Environment.NewLine);
        }
    }
}
