using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class TennisPlayer : Player
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
            throw new NotImplementedException("Soy jugador de tenis y no necesito un equipo para jugar.");
        }
    }
}
