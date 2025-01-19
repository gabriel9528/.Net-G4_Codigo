using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter_Before.Adaptee;
using Adapter_Before.Target;

namespace Adapter_Before.Adapter
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XMLConverter _xmlConverter;

        public XmlToJsonAdapter(XMLConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }
        public string ConvertXmlToJson()
        {
            var products = _xmlConverter.GetXml()
                .Root.Elements("Producto")
                .Select(p => new Producto
                {
                    Precio = Convert.ToInt32(p.Attribute("Precio").Value),
                    Nombre = p.Attribute("Nombre").Value
                });

            return new JsonConverter(products).ConverToJson();
        }
    }
}
