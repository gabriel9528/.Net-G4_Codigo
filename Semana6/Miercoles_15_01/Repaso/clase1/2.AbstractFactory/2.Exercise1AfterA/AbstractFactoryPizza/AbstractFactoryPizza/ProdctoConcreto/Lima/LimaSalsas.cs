using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.ProdctoConcreto.Lima
{
    internal class LimaSalsas : ISalsas
    {
        public void SalsaMarinada()
        {
            Console.WriteLine("Agregando salsa marinada - Lima " + Environment.NewLine);
        }
    }
}
