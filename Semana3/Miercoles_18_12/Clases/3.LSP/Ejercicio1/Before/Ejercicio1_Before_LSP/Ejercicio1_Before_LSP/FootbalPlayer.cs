using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before_LSP
{
    internal class FootbalPlayer : Player
    {
        public override string GetMarketValue(PlayerCategory playerCategory)
        {
            string marketValue = "";
            switch(playerCategory)
            {
                case PlayerCategory.Amateur:
                    marketValue = "100";
                    break;

                case PlayerCategory.Profesional:
                    marketValue = "1000";
                    break;
            }
            return marketValue;
        }

        //public override void AssigTeam(Team team)
        //{
        //    Console.WriteLine($"Jugador asignado al equipo: {team.Name}");
        //}
    }
}
