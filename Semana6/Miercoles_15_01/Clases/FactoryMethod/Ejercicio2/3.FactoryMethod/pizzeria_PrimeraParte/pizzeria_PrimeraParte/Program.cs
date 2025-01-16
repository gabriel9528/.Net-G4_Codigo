
public class Pizza
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

//Crear clase para ordenar pizza

public class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = null;

        switch (type)
        {
            case "Peperoni":
                pizza = new PeperoniPizza();
                break;
            case "Vegetariana":
                pizza = new VegetarianaPizza();
                break;
            case "Napolitana":
                pizza = new NapolitanaPizza();
                break;
        }

        if(pizza != null)
        {
            pizza.Preparar();
            pizza.Cocinar();
            pizza.Cortar();
            pizza.Encajar();
        }

        return pizza;
    }

}

internal class PeperoniPizza : Pizza
{
    public PeperoniPizza()
    {
        Nombre = "Peperoni";
        Masa = "Delgada Peperoni";
        Salsas = "Tomate Peperoni";
        Extras.Add("Salsa de peperoni");
    }
}

internal class VegetarianaPizza : Pizza
{
    public VegetarianaPizza()
    {
        Nombre = "Vegetariana";
        Masa = "Delgada Vegetariana";
        Salsas = "Marinada Vegetariana";
        Extras.Add("Salsa de vegetales");
        Extras.Add("Aceite de oliva");
        Extras.Add("Salsa de ajo");
    }
}

internal class NapolitanaPizza : Pizza
{
    public NapolitanaPizza()
    {
        Nombre = "Napolitana";
        Masa = "Gruesa Napolitana";
        Salsas = "Tomate Napolitana";
        Extras.Add("Salsa Naploitana");
        Extras.Add("Mayonesa");
    }
}


class Program
{
    static void Main(string[] args)
    {
        PizzaStore myStore = new PizzaStore();
        var pizza = myStore.OrderPizza("Napolitana");
        Console.WriteLine($"Pizza: {pizza.Nombre}, Masa: {pizza.Masa},  lista para ser entregada");
        Console.ReadLine();
    }
}


