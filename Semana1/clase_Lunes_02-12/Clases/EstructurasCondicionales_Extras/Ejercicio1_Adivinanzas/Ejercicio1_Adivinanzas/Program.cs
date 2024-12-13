//Juego de Adivinanzas con numeros


// Generar un número aleatorio entre 1 y 100
Random random = new Random();
int numeroSecreto = random.Next(1, 101);

// Inicializar variables
int intentos = 0;
int intentoUsuario = 0;

Console.WriteLine("Bienvenido al juego de adivinanzas!");
Console.WriteLine("Intenta adivinar un número entre 1 y 100.");

// Juego
while (intentoUsuario != numeroSecreto)
{
    Console.Write("Ingrese su intento: ");
    intentoUsuario = int.Parse(Console.ReadLine());

    intentos++;

    if (intentoUsuario < numeroSecreto)
    {
        Console.WriteLine("El número es demasiado bajo. ¡Inténtalo de nuevo!");
    }
    else if (intentoUsuario > numeroSecreto)
    {
        Console.WriteLine("El número es demasiado alto. ¡Inténtalo de nuevo!");
    }
    else
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número secreto en {0} intentos.", intentos);
    }
}