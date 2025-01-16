using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.ProdctoConcreto.Arequipa
{
    internal class ArequipaMasa : IMasa
    {
        public void MasaDelgada()
        {
            Console.WriteLine("Agregando masa delgada - Arequipa " + Environment.NewLine);
        }
    }
}
