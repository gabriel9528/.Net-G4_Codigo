class Program
{
    public static void Main(string[] args)
    {
        //Crear un diccionario que almacene los nombres y sus calificaciones
        Dictionary<string, int> estudiantesDictionary = new Dictionary<string, int>()
        {
            {"Gabriel", 15 },
            {"Andrea", 20 },
            {"Pepito", 18 },
            {"Jose", 10 },
            {"Luna", 13 },
        };

        Console.WriteLine("Ingrese el nombre del estudiante");

        string nombre = Console.ReadLine();

        if (estudiantesDictionary.ContainsKey(nombre))
        {
            Console.WriteLine($"La calificacion de {nombre} es: {estudiantesDictionary[nombre]}");
        }
        else
        {
            Console.WriteLine("El estudiante no fue encontrado");
        }
    }

};