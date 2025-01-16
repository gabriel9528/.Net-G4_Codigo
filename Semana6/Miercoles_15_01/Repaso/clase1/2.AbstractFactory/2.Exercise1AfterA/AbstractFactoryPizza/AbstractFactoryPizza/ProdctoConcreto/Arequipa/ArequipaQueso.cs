using Abstract.ProductoAbstracto.Interfaces;

namespace Abstract.ProdctoConcreto.Arequipa
{
    internal class ArequipaQueso : IQueso
    {
        public void QuesoParmesano()
        {
            Console.WriteLine("Agregando queso parmesano - Arequipa " + Environment.NewLine);
        }
    }
}
