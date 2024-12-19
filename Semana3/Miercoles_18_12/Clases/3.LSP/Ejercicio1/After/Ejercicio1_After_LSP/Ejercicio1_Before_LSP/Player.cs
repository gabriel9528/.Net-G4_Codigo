using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before_LSP
{
    public class Player : IPlayer
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public PlayerCategory Category { get ; set ; }

        public string GetMarketValue(PlayerCategory playerCategory)
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

        public void SetCategory(PlayerCategory playerCategory)
        {
            Category = playerCategory;
        }
    }
}
