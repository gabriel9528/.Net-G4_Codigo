using Adapter_Before;
using Adapter_Before.Adaptee;
using Adapter_Before.Adapter;
using Adapter_Before.Target;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("------Prueba solo con JsonConverter--------");
        Console.WriteLine("Adapter Before");
        var xmlConverter1 = new XMLConverter();
        Console.WriteLine(xmlConverter1.GetXml());

        //---------------After----------------------------------------------------
        Console.WriteLine("--------------");
        Console.WriteLine("Adapter After");
        Console.WriteLine("Converting XML to JSON");
        var xmlConverter = new XMLConverter();

        IXmlToJson xmlToJson = new XmlToJsonAdapter(xmlConverter);

        var jsonConverter = new JsonClient();
        string resultJson = jsonConverter.ConverToJson(xmlToJson);
        Console.WriteLine(resultJson);
        Console.ReadLine();

        //**************************************************************
        //**************************************************************
        //var xmlConverter1 = new XMLConverter();
        //Console.WriteLine("Adapter Before");
        //Console.WriteLine(xmlConverter1.GetXml());


    }
}