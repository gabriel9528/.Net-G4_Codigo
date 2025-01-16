using AbstractFactoryPizza;
using AbstractFactoryPizza.CreadorAbastracto;
using AbstractFactoryPizza.CreadorConcreto;
using AbstractFactoryPizza.ProductoAbstracto;

class Program
{

    static void Main(string[] args)
    {
        PizzaStore store = new LimaPizzaStore();
        Pizza pizza = store.OrderPizza(TypeOfPizza.Vegetariana);
        Console.WriteLine($"Pizza {pizza.Nombre} lista para ser entregada a Gabriel");
        Console.ReadLine();
    }
}