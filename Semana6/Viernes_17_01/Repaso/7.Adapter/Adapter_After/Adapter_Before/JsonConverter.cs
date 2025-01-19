using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Before
{
    internal class JsonConverter
    {
        //public string GetJson() 
        //{
        //    return "[{\"Nombre\":\"Iphone 13\",\"Precio\":1500},{\"Nombre\":\"Samsung x-200\",\"Precio\":2000},{\"Nombre\":\"Xaomi\",\"Precio\":800},{\"Nombre\":\"Huawei\",\"Precio\":900},{\"Nombre\":\"Motorola\",\"Precio\":600}]";
        //}

        private IEnumerable<Producto> _listProducts;

        public JsonConverter(IEnumerable<Producto> listProducts)
        {
            _listProducts = listProducts;
        }

        public string ConverToJson()
        {
            return JsonConvert.SerializeObject(_listProducts, Formatting.Indented);

        }
    }
}
