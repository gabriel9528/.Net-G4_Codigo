using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.ProdctoConcreto.Arequipa
{
    internal class ArequipaSalsas : ISalsas
    {
        public void SalsaMarinada()
        {
            Console.WriteLine("Agregando salsa marinada - Arequipa " + Environment.NewLine);
        }
    }
}
