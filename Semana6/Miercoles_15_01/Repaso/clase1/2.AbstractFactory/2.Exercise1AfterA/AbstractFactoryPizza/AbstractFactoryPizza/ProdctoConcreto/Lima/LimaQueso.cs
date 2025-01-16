using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.ProdctoConcreto.Lima
{
    internal class LimaQueso : IQueso
    {
        public void QuesoParmesano()
        {
            Console.WriteLine("Agregando queso parmesano - Lima " + Environment.NewLine);
        }
    }
}
