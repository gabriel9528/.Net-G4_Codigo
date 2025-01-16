using AbstractFactoryPizza.Cliente;
using AbstractFactoryPizza.FabricaAbstracta;
using AbstractFactoryPizza.FabricasConcretas;

class Program
{

    static void Main(string[] args)
    {
        IPizzaIngredientesFactory pizzaIngredientesFactory = new ArequipaPizzaIngredientesFactory();
        NapolitanaPizza pizza = new NapolitanaPizza(pizzaIngredientesFactory);
        pizza.Cocinar();
        pizza.Encajar();
        pizza.Cortar();
        pizza.Preparar();
    }
}