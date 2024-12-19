

using Ejercicio2__After_ISP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demostracion del principio de segregacion de interfaces");
        Console.WriteLine("");
        Console.WriteLine("");

        //Instancia del carro
        Console.WriteLine("Iniciando el carro");
        IVehicle car = new Car();
        IEngineVehicle car2 = new Car();
        Car car3 = new Car();

        car.Move();
        car.GetNumberOfWheels();

        car2.StarEngine();
        car2.StopEngine();


        Console.WriteLine("**********************************************************");
        Console.WriteLine("");
        Console.WriteLine("");

        //Instancia de la bicileta
        Console.WriteLine("Iniciando la bicicleta");
        IVehicle bicycle = new Bicycle();

        bicycle.Move();
        bicycle.GetNumberOfWheels();

    }
}