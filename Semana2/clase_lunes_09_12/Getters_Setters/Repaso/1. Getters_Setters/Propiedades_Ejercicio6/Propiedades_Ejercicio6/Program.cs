using System;

public class HabitacionHotel
{
    private bool ocupada;

    public int NumeroHabitacion { get; set; }

    public bool Ocupada
    {
        get { return ocupada; }
        set
        {
            ocupada = value;
            Console.WriteLine(ocupada ? $"La habitación {NumeroHabitacion} ahora está ocupada." : 
                $"La habitación {NumeroHabitacion} ahora está libre.");
        }
    }
}

class Program
{
    static void Main()
    {
        HabitacionHotel habitacion = new HabitacionHotel();

        Console.Write("Ingrese el número de la habitación: ");
        if (int.TryParse(Console.ReadLine(), out int numeroHabitacion))
        {
            habitacion.NumeroHabitacion = numeroHabitacion;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Se asignará el número de habitación como 0.");
            habitacion.NumeroHabitacion = 0;
        }

        Console.Write("¿Está la habitación ocupada? (sí/no): ");
        string respuesta = Console.ReadLine()?.Trim().ToLower();

        if (respuesta == "sí" || respuesta == "si")
        {
            habitacion.Ocupada = true;
        }
        else if (respuesta == "no")
        {
            habitacion.Ocupada = false;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Se considerará que la habitación está libre.");
            habitacion.Ocupada = false;
        }

        Console.WriteLine($"Estado final de la habitación {habitacion.NumeroHabitacion}: {(habitacion.Ocupada ? "Ocupada" : "Libre")}");
    }
}
