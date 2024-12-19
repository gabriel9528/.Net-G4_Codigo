using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPLibrary
{
    public class FootballPlayer : Player
    {
        public override string GetMarketValue(PlayerCategory category)
        {
            string marketValue = "";
            switch (category)
            {
                case PlayerCategory.Amateur:
                    marketValue = "100";
                    break;
                case PlayerCategory.Professional:
                    marketValue = "1000";
                    break;
            }
            return marketValue;
        }

        public override void AssignTeam(Team team)
        {
            Console.WriteLine($"Jugador asignado al equipo: {team.Name}");
        }
    }
}