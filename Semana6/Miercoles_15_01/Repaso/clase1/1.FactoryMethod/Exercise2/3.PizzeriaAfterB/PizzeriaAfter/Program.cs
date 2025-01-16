// See httpusing System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PizzeriaAfter
{
    //Diseñar un sistema que tenga varios locales y nosotros como clientes podamos ordenar
    //las pizzas a distintos locales

    //Producto abstracto
    public class Pizza
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

    //Creador Abstracto
    public abstract class PizzaStoreFactory
    {
        public abstract Pizza CreatePizza(TypeOfPizza type);

        public Pizza OrderPizza(TypeOfPizza type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Cocinar();
            pizza.Cortar();
            pizza.Encajar();

            return pizza;

        }
    }

    public enum TypeOfPizza
    {
        Peperoni,
        Napolitana,
        Vegetariana
    }

    //Creador concreto Arequipa
    public class ArequipaPizzaStore : PizzaStoreFactory
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            //El Activator en .NET es una clase que proporciona métodos para crear instancias de
            //tipos durante el tiempo de ejecución. El método Activator.CreateInstance se utiliza
            //para crear una instancia de un tipo especificado dinámicamente.
            //Esto es particularmente útil cuando el tipo no se conoce en tiempo de compilación
            //y debe ser determinado en tiempo de ejecución.

            //El Activator se utiliza para crear instancias de diferentes tipos de pizzas basándose
            //en un nombre de tipo construido dinámicamente.
            //Por ejemplo, si type es TypeOfPizza.Pepperoni, el nombre completo
            //sería "PizzeriaAfter.ArequipaPepperoniPizza".
            return (Pizza)Activator.
                //aqui tenemos que llamar a -> ArequipaPeperoniPizza
                CreateInstance(Type.GetType($"PizzeriaAfter.Arequipa{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));

        }

    }

    //Creador concreto Lima
    public class LimaPizzaStore : PizzaStoreFactory
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            return (Pizza)Activator.
                 //aqui tenemos que llamar a -> LimaPeperoniPizza
                 CreateInstance(Type.GetType($"PizzeriaAfter.Lima{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }

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

    internal class ArequipaNapolitanPizza : Pizza
    {
        public ArequipaNapolitanPizza()
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


    class Program
    {

        static void Main(string[] args)
        {
            PizzaStoreFactory store = new ArequipaPizzaStore();
            Pizza pizza = store.OrderPizza(TypeOfPizza.Vegetariana);
            WriteLine($"Pizza {pizza.Nombre} lista para ser entregada a Gabriel");
            ReadLine();
        }
    }

}