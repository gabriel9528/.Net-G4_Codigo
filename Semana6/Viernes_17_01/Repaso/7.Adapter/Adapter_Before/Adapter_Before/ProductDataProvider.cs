using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Before
{
    public static class ProductDataProvider
    {
        public static List<Producto> GetProducts()
        {
            return new List<Producto>
            {
                new Producto("Iphone 13", 1500),
                new Producto("Samsung x-200", 2000),
                new Producto("Xaomi", 800),
                new Producto("Huawei", 900),
                new Producto("Motorola", 600),
            };
        }
    }
}
