

using System.Text.Json;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this T source)
    {
        if( source == null)
        {
            throw new ArgumentNullException(nameof(source), "La fuente a copiar no puerte estar vacia");
        }

        var options = new JsonSerializerOptions
        {
            WriteIndented = false,
            IncludeFields = true,
        };

        //Serializar nuestro objeto -> Convertirlo en un string
        var jsonString = JsonSerializer.Serialize(source, options);

        //Deserializacion -> convertir el string en el objeto original
        return JsonSerializer.Deserialize<T>(jsonString, options);

    }
}


public class Category
{
    public string Name { get; set; }
    public Category(string name)
    {
        Name = name;
    }
}

public class Product
{
    public string Name { get; set; }
    public Category Category { get; set; }

    public Product(string name, Category category)
    {
        Name = name;
        Category = category;
    }

    public override string ToString()
    {
        return $"Product: {Name}, Category: {Category.Name}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product notebook = new Product("MackBook Pro", new Category("Computers"));

        Product iphone = notebook.DeepCopy();

        iphone.Name = "Iphone";
        iphone.Category.Name = "Cellphones";

        Console.WriteLine(notebook);
        Console.WriteLine("*********************************************");
        Console.WriteLine(iphone);
    }
}