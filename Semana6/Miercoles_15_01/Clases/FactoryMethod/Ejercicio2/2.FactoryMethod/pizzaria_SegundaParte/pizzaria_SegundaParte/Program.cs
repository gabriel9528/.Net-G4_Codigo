

#region Producto abstracto
//Producto Abstracto
public abstract class Pizza
{
    public string Nombre { get; set; }
    public string Masa { get; set; }
    public string Salsas { get; set; }
    public List<string> Extras { get; set; } = new List<string>();

    public void Preparar()
    {
        Console.WriteLine($"Preparando: {Nombre}");
        Console.WriteLine($"Colocando la masa: {Masa}");
        Console.WriteLine($"Agregando salsas: {Salsas}");
        Console.WriteLine($"Agregando extras: {string.Join(", ", Extras)}");
    }

    public void Cocinar() => Console.WriteLine("Cocinar pizza por 20 minutos");
    public void Cortar() => Console.WriteLine("La pizza fue cortada en partes iguales");
    public void Encajar() => Console.WriteLine("Pizza colocada en su caja");

}
#endregion

#region Productos Concretos

//Producto concreto Arequipa
internal class ArequipaPeperoniPizza : Pizza
{
    public ArequipaPeperoniPizza()
    {
        Nombre = "Arequipa Peperoni";
        Masa = "Delgada Peperoni";
        Salsas = "Tomate Peperoni";
        Extras.Add("Salsa de peperoni");
    }
}

internal class ArequipaVegetarianaPizza : Pizza
{
    public ArequipaVegetarianaPizza()
    {
        Nombre = "Arequipa Vegetariana";
        Masa = "Delgada Vegetariana";
        Salsas = "Marinada Vegetariana";
        Extras.Add("Salsa de vegetales");
        Extras.Add("Aceite de oliva");
        Extras.Add("Salsa de ajo");
    }
}

internal class ArequipaNapolitanaPizza : Pizza
{
    public ArequipaNapolitanaPizza()
    {
        Nombre = "Arequipa Napolitana";
        Masa = "Gruesa Napolitana";
        Salsas = "Tomate Napolitana";
        Extras.Add("Salsa Naploitana");
        Extras.Add("Mayonesa");
    }
}

//Producto concreto Lima
internal class LimaPeperoniPizza : Pizza
{
    public LimaPeperoniPizza()
    {
        Nombre = "Lima Peperoni";
        Masa = "Delgada Peperoni";
        Salsas = "Tomate Peperoni";
        Extras.Add("Salsa de peperoni");
    }
}

internal class LimaVegetarianaPizza : Pizza
{
    public LimaVegetarianaPizza()
    {
        Nombre = "Lima Vegetariana";
        Masa = "Delgada Vegetariana";
        Salsas = "Marinada Vegetariana";
        Extras.Add("Salsa de vegetales");
        Extras.Add("Aceite de oliva");
        Extras.Add("Salsa de ajo");
    }
}

internal class LimaNapolitanaPizza : Pizza
{
    public LimaNapolitanaPizza()
    {
        Nombre = "Lima Napolitana";
        Masa = "Gruesa Napolitana";
        Salsas = "Tomate Napolitana";
        Extras.Add("Salsa Naploitana");
        Extras.Add("Mayonesa");
    }
}

#endregion

#region Creador Abstracto

public abstract class PizzaStoreFactory
{
    public abstract Pizza CreatePizza(string name);

    public Pizza OrderPizza(string name)
    {
        Pizza pizza = CreatePizza(name);

        pizza.Preparar();
        pizza.Cocinar();
        pizza.Cortar();
        pizza.Encajar();

        return pizza;

    }
}

#endregion

#region Creadores Concretos

//Creador concreto para Arequipa
public class ArequipaPizzaStore : PizzaStoreFactory
{
    public override Pizza CreatePizza(string name)
    {
        switch (name)
        {
            case "Peperoni":
                return new ArequipaPeperoniPizza();
            case "Napolitana":
                return new ArequipaNapolitanaPizza();
            case "Vegetariana":
                return new ArequipaVegetarianaPizza();
            default:
                return null;
        }
    }
}

//Creador concreto para Lima
public class LimaPizzaStore : PizzaStoreFactory
{
    public override Pizza CreatePizza(string name)
    {
        switch (name)
        {
            case "Peperoni":
                return new LimaPeperoniPizza();
            case "Napolitana":
                return new LimaNapolitanaPizza();
            case "Vegetariana":
                return new LimaVegetarianaPizza();
            default:
                return null;
        }
    }
}

#endregion


class Program
{
    static void Main(string[] args)
    {
        PizzaStoreFactory storeFactory = new LimaPizzaStore();
        Pizza pizza = storeFactory.OrderPizza("Peperoni");
        Console.WriteLine($"Pizza: {pizza.Nombre}, Masa: {pizza.Masa},  lista para ser entregada");
        Console.ReadLine();
    }
}