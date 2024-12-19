using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before_LSP
{
    internal class TennispLayer : Player
    {
        public override string GetMarketValue(PlayerCategory playerCategory)
        {
            string marketValue = "";
            switch (playerCategory)
            {
                case PlayerCategory.Amateur:
                    marketValue = "5000";
                    break;

                case PlayerCategory.Profesional:
                    marketValue = "20000";
                    break;
            }
            return marketValue;
        }

        public override void AssigTeam(Team team)
        {
            throw new NotImplementedException("Soy un jugador de tennis y no necesito un equipo para jugar");
        }
    }
}
