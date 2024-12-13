using Herencia_Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Nombre = "Andres";
        persona.Edad = 50;
        //Console.WriteLine(persona.ToString());
        persona.Imprimir();

        Console.WriteLine("************************************************************************");

        Empleado empleado = new Empleado();
        empleado.Nombre = "Maria";
        empleado.Edad = 32;
        empleado.Sueldo = 2000;
        //Console.WriteLine(empleado.ToString());
        empleado.Imprimir();
    }
}