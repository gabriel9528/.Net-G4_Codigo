class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio taba de multíplicar");
        Console.WriteLine("****************************");
        
        int number = Convert.ToInt32(Console.ReadLine());

        for(var i = 0; i <= number; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }

    }
}