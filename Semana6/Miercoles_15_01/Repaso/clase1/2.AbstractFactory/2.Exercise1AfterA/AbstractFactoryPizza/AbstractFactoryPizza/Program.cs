using Abstract.FabricaAbstracta;
using Abstract.FabricaConcreta;
using Abstract.PizzaModel;

class Program
{
    //static void Main(string[] args)
    //{
    //    PizzaStore arequipaStore = new ArequipaPizzaStore();
    //    Pizza pizza = arequipaStore.OrderPizza("Peperoni");
    //    WriteLine($"Pizza {pizza.Nombre} lista para ser entregada a Gabriel");
    //    ReadLine();
    //}

    static void Main(string[] args)
    {
        IPizzaIngredientesFactory pizzaIngredientesFactory = new ArequipaPizzaIngredientesFactory();
        NapolitanaPizza pizza = new NapolitanaPizza(pizzaIngredientesFactory);
        pizza.Cocinar();
        pizza.Prepare();
        pizza.Cortar();
        pizza.Encajar();

    }
}