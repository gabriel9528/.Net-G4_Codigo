//Juego del Tragamonedas

Console.WriteLine("¡Bienvenido al juego de Tragamonedas!");

bool continuar = true;
int saldo = 100; // Saldo inicial del jugador

while (continuar)
{
    Console.WriteLine("\nTu saldo actual es: {0} créditos.", saldo);
    Console.Write("¿Quieres jugar? (s/n): ");
    string respuesta = Console.ReadLine();

    if (respuesta.ToLower() != "s")
    {
        continuar = false;
        Console.WriteLine("¡Gracias por jugar! Tu saldo final es: {0} créditos.", saldo);
        break;
    }

    if (saldo <= 0)
    {
        Console.WriteLine("Lo siento, no tienes suficientes créditos para jugar.");
        continuar = false;
        break;
    }

    // Girar los rodillos
    Random random = new Random();
    string[] rodillos = { "Cereza", "Limón", "Naranja" };
    string rodillo1 = rodillos[random.Next(rodillos.Length)];
    string rodillo2 = rodillos[random.Next(rodillos.Length)];
    string rodillo3 = rodillos[random.Next(rodillos.Length)];

    Console.WriteLine("Resultado del giro: {0} - {1} - {2}", rodillo1, rodillo2, rodillo3);

    // Verificar premio
    if (rodillo1 == rodillo2 && rodillo2 == rodillo3)
    {
        switch (rodillo1)
        {
            case "Cereza":
                saldo += 50; // Premio mayor
                Console.WriteLine("¡Felicidades! Ganaste el premio mayor de 50 créditos.");
                break;
            case "Limón":
                saldo += 20; // Premio medio
                Console.WriteLine("¡Felicidades! Ganaste el premio medio de 20 créditos.");
                break;
            case "Naranja":
                saldo += 10; // Premio menor
                Console.WriteLine("¡Felicidades! Ganaste el premio menor de 10 créditos.");
                break;
        }
    }
    else
    {
        saldo -= 10; // Apuesta mínima
        Console.WriteLine("Lo siento, no ganaste. Perdiste 10 créditos.");
    }
}