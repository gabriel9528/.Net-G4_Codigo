using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter_Before.Adaptee
{
    //tiene como propósito convertir datos de productos a un formato XML
    //XDocument, que representa un documento XML.
    public class XMLConverter
    {
        public XDocument GetXml()
        {
            var xDocument = new XDocument();
            //Crea un nuevo elemento XML llamado Productos, que actuará como el elemento raíz que
            //contendrá todos los elementos de producto.
            var xElement = new XElement("Productos");

            //Supone la existencia de un proveedor de datos de productos (ProductDataProvider) con
            //un método GetProducts() que devuelve una colección de productos.
            var xAttributes = ProductDataProvider.GetProducts()
                //Utiliza LINQ para seleccionar cada producto en la colección y crear un nuevo
                //elemento XML Producto para cada uno de ellos.
                .Select(p => new XElement("Producto",
                    //Añade un atributo Nombre al elemento Producto con el valor del nombre del producto.
                    new XAttribute("Nombre", p.Nombre),
                    //Añade un atributo Precio al elemento Producto con el valor del precio del producto.
                    new XAttribute("Precio", p.Precio)
                ));
            //Añade todos los elementos Producto creados al elemento Productos.
            xElement.Add(xAttributes);
            //Añade el elemento Productos (que ahora contiene todos los elementos Producto) al documento XML.
            xDocument.Add(xElement);
            return xDocument;

            //El propósito de esta clase y método es convertir una colección de objetos de producto en una
            //estructura XML. Cada producto se convierte en un elemento Producto con atributos Nombre y Precio, 
            //y todos estos elementos se agrupan bajo un elemento raíz Productos. El resultado es un
            //documento XML que representa la colección de productos, que se puede utilizar para diversas
            //finalidades, como almacenamiento, intercambio de datos o generación de informes.
        }
    }
}
