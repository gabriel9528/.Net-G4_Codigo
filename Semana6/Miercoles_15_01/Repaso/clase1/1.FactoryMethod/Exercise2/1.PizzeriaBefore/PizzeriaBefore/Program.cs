using System;
using System.Collections.Generic;
using static System.Console;

namespace PizzaFactory
{
    // Diseñar un sistema que tenga varios locales y nosotros como clientes podamos
    // ordenar las pizzas a distintos locales
    public class Pizza
    {
        public string Nombre { get; set; }
        protected string Masa { get; set; }
        protected string Salsas { get; set; }

        protected List<string> Extras = new List<string>();

        public void Prepare()
        {
            WriteLine($"Prepararando: {Nombre}");
            WriteLine($"Colocando masa: {Masa}");
            WriteLine($"Agregando salsa: {Salsas}");
            WriteLine($"Agregando Capas: {string.Join(",", Extras)}");
        }
        public void Cocinar() => WriteLine($"Cocinar por 20 min");
        public void Cortar() => WriteLine($"Pizza fue cortada en partes iguales");
        public void Encajar() => WriteLine($"Pizza colocada en caja oficial");
    }

    //Clase para ordenar una pizza
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
                case "Napolitana":
                    pizza = new NapolitanaPizza();
                    break;
                case "Vegetariana":
                    pizza = new VegetarianaPizza();
                    break;
            }

            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Cocinar();
                pizza.Cortar();
                pizza.Encajar();
            }

            return pizza;
        }
    }

    //public abstract class PizzaStore
    //{
    //    public abstract Pizza CreatePizza(string name);
    //    public Pizza OrderPizza(string name)
    //    {
    //        Pizza pizza = CreatePizza(name);
    //        pizza.Prepare();
    //        pizza.Cocinar();
    //        pizza.Cortar();
    //        pizza.Encajar();

    //        return pizza;
    //    }
    //}

    internal class PeperoniPizza : Pizza
    {
        public PeperoniPizza()
        {
            Nombre = "Peperoni";
            Masa = "Thin";
            Salsas = "Tomato123";
            Extras.Add("Pepperoni slices");
        }
    }

    internal class VegetarianaPizza : Pizza
    {
        public VegetarianaPizza()
        {
            Nombre = "Vegetariana";
            Masa = "Whole Wheat";
            Salsas = "Marinada";
            Extras.Add("Bell Peppers");
            Extras.Add("Olives");
            Extras.Add("Onions");
        }
    }

    internal class NapolitanaPizza : Pizza
    {
        public NapolitanaPizza()
        {
            Nombre = "Napolitana";
            Masa = "Thick";
            Salsas = "Tomato Basil";
            Extras.Add("Fresh Mozzarella");
            Extras.Add("Basil Leaves");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore myStore = new PizzaStore();
            Pizza pizza = myStore.OrderPizza("Peperoni");
            WriteLine($"Pizza {pizza.Nombre} lista para ser entregada a Gabriel");
            ReadLine();
        }
    }
}
