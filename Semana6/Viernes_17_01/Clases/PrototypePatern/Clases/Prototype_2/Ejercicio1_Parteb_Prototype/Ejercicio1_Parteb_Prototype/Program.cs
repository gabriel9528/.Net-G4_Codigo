
public interface IPrototype<T>
{
    T DeepCopy();
}

public class Category : IPrototype<Category>
{
    public string Name { get; set; }
    public Category(string name)
    {
        Name = name;
    }

    public Category DeepCopy()
    {
        return new Category(Name);
    }
}

public class Product : IPrototype<Product>
{
    public string Name { get; set; }
    public Category Category { get; set; }

    public Product(string name, Category category)
    {
        Name = name;
        Category = category;
    }

    public Product DeepCopy()
    {
        return new Product(Name, Category.DeepCopy());
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

        Product iphone = (Product)notebook.DeepCopy();

        iphone.Name = "Iphone";
        iphone.Category.Name = "Cellphones";

        Console.WriteLine(notebook);
        Console.WriteLine("*********************************************");
        Console.WriteLine(iphone);
    }

}