

using Encapsulamiento_Ejercicio1;

class Program()
{
    //static void Main(string[] args)
    //{
    //    Persona alumno = new Persona();

    //    alumno.nombre = "Pepito";
    //    alumno.fechaNacimiento = Convert.ToDateTime("15/11/2000");

    //    alumno.RegistrarPersona();
    //    Console.ReadLine();
    //}

    static void Main(string[] args)
    {
        PersonaPropiedades alumno = new ();

        alumno.Nombre = "Pepito";
        alumno.FechaNacimiento = Convert.ToDateTime("15/11/2000");

        alumno.RegistrarPersona();
        Console.ReadLine();

    }
}