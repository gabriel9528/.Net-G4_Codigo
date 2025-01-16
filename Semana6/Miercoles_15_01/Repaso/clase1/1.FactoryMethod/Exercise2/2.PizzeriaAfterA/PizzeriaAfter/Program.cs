// See httpusing System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PizzeriaAfter
{
    //Diseñar un sistema que tenga varios locales y nosotros como clientes podamos
    //ordenar las pizzas a distintos locales
    
    //Producto abstracto
    public abstract class Pizza
    {
        public string Nombre { get; set; }
        protected string Masa;
        protected string Salsas;
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

    //Productos concretos
    #region Arequipa Pizza
    internal class ArequipaPeperoniPizza : Pizza
    {
        public ArequipaPeperoniPizza()
        {
            Nombre = "Peperoni";
            Masa = "delgada";
            Salsas = "Salsa de tomates";
            Extras.Add("Quesso mozarella");
        }
    }

    internal class ArequipaVegetarianaPizza : Pizza
    {
        public ArequipaVegetarianaPizza()
        {
            Nombre = "Vegetariana";
            Masa = "delgada";
            Salsas = "Salsa de tomates";
            Extras.Add("Quesso mozarella");
        }
    }

    internal class ArequipaNapolitanaPizza : Pizza
    {
        public ArequipaNapolitanaPizza()
        {
            Nombre = "Napolitana";
            Masa = "delgada";
            Salsas = "Salsa de tomates";
            Extras.Add("Quesso mozarella");
        }
    }
    #endregion

    #region Lima Pizza
    internal class LimaPeperoniPizza : Pizza
    {
        public LimaPeperoniPizza()
        {
            Nombre = "Peperoni";
            Masa = "delgada";
            Salsas = "Salsa de tomates";
            Extras.Add("Quesso mozarella");
        }
    }

    internal class LimaVegetarianaPizza : Pizza
    {
        public LimaVegetarianaPizza()
        {
            Nombre = "Vegetariana";
            Masa = "delgada";
            Salsas = "Salsa de tomates";
            Extras.Add("Quesso mozarella");
        }
    }

    internal class LimaNapolitanaPizza : Pizza
    {
        public LimaNapolitanaPizza()
        {
            Nombre = "Napolitana";
            Masa = "delgada";
            Salsas = "Salsa de tomates";
            Extras.Add("Quesso mozarella");
        }
    }

    #endregion





    //Creador Abstracto
    public abstract class PizzaStoreFactory
    {
        public abstract Pizza CreatePizza(string name);

        public Pizza OrderPizza(string name)
        {
            Pizza pizza = CreatePizza(name);

            pizza.Prepare();
            pizza.Cocinar();
            pizza.Cortar();
            pizza.Encajar();

            return pizza;

        }
    }

   
    //Creador concreto
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



    

    class Program
    {
        static void Main(string[] args)
        {
            PizzaStoreFactory arequipaStore = new ArequipaPizzaStore();
            Pizza pizza = arequipaStore.OrderPizza("Peperoni");
            WriteLine($"Pizza {pizza.Nombre} lista para ser entregada a Gabriel");
            ReadLine();
        }

    }

}