using Encapsulamiento1;

public class Program
{
    //Ejercicio 1
    static void Main(string[] args)
    {
        Persona alumno = new Persona();
        alumno.nombre = "Roger";
        alumno.fechaNacimiento = Convert.ToDateTime("10/10/1996");
        alumno.registrar();
        Console.ReadKey();
    }

    //Ejercicio2
    //static void Main(string[] args)
    //{
    //    PersonaPropiedades alumno = new PersonaPropiedades();
    //    alumno.Nombre = "Roger";
    //    alumno.FechaNacimiento = Convert.ToDateTime("10/10/1996");
    //    alumno.registrar();
    //    Console.WriteLine("la edad del alumno " + alumno.Nombre + " es " + alumno.Edad);


    //    //el valor de la edad se puede obtener por que la propiedad GET es Publico, pero no se puede actualizar porque es private
    //    Console.WriteLine(alumno.Edad);
    //    //alumno.Edad = 15;

    //    Console.ReadKey();
    //}
}