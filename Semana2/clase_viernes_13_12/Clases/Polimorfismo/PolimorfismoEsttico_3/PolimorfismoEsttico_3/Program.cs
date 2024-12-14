

using PolimorfismoEsttico_3;

class Program
{
    static void Main(string[] args)
    {
        //Crear una instancia de cada clase
        Casa casa1 = new Casa();
        Casa casa2 = new Casa("Casa de campo", 100000);
        Casa casa3 = new Casa("Casa moderna", 100000, 1000, 800);

        casa1.Tipo = "Casa tradicional";
        casa1.Precio = 2000000;
        casa1.AreaTerreno = 5000;
        casa1.AreaConstruida = 3000;

        casa1.Vender();
        casa1.Vender("Gabriel");
        casa1.Vender("Pepito", 6000);
    }
}