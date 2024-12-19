
using Ejercicio1_Before_LSP;

class Program
{
    static void Main(string[] args)
    {
        Player footbolPlayer = new TennispLayer();
        footbolPlayer.FirstName = "Cristiano";
        footbolPlayer.LastName = "Ronaldo";
        footbolPlayer.AssigTeam(new Team
        {
            Name = "Real Madrid"
        });
        footbolPlayer.SetCategory(PlayerCategory.Profesional);

        Console.WriteLine($"{footbolPlayer.FirstName}, " +
            $"{footbolPlayer.LastName}, " +
            $"equipo: {footbolPlayer.GetTeam()}, " +
            $"categoria: {footbolPlayer.Category}" +
            $"valor de mercado: {footbolPlayer.GetMarketValue(PlayerCategory.Profesional)}");

        Console.ReadLine();
    }
}