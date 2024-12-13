public class Persona
{
    // Propiedades
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Método para mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}

// Uso de la clase Persona
public class Program
{
    public static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Nombre = "Juan";
        persona.Edad = 30;
        persona.MostrarInformacion(); // Salida: Nombre: Juan, Edad: 30
    }
}
