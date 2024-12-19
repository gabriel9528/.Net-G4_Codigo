using LSPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayerTeam player = new FootballPlayer();
            player.FirstName = "Gabriel";
            player.LastName = "Retamozo";
            player.AssignTeam(new Team { Name = "Melgar" });
            player.SetCategory(PlayerCategory.Amateur);

            Console.Write($"{player.FirstName} {player.LastName}  categoria  {player.Category}");
            Console.ReadLine();
        }
    }
}
