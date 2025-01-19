
public class Category : ICloneable
{
    public string Name { get; set; }
    public Category(string name)
    {
        Name = name;
    }

    public object Clone()
    {
        return new Category(Name);
    }
}

public class Product : ICloneable
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

    public object Clone()
    {
        //return new Product(Name, Category);
        return new Product(Name, (Category)Category.Clone());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product notebook = new Product("MackBook Pro", new Category("Computers"));

        Product iphone = (Product)notebook.Clone();

        iphone.Name = "New Iphone";
        iphone.Category.Name = "Cellphones";

        Console.WriteLine(notebook);
        Console.WriteLine("*********************************************");
        Console.WriteLine(iphone);
    }

}