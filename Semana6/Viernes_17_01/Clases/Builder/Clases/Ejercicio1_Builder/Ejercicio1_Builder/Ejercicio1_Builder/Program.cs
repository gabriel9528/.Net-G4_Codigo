using Ejercicio1_Builder.Builder;
using Ejercicio1_Builder.ConcreteBuilder;
using Ejercicio1_Builder.Director;
using Ejercicio1_Builder.Product;

class Program
{
    static void Main(string[] args)
    {
        //Crear el director
        SandwichAssembly director = new SandwichAssembly();

        //Configurar el constructor correcto
        SandwichBuilder cheeseBurger = new CheeseBurger();

        director.SetBuilder(cheeseBurger);

        //Construir el sandwich
        director.Assembly();

        //Obtener el sandwich construido
        Sandwich sandwich = director.GetSandwich();

        Console.WriteLine("Sandwich constuido Cheese Burger");
        Console.WriteLine(sandwich);
        Console.ReadLine();
    }
}