using System;

namespace LSPLibrary
{
    public class Player : IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerCategory Category { get; set; }

        public string GetMarketValue(PlayerCategory category)
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

        public virtual void SetCategory(PlayerCategory category)
        {
            Category = category;
        }

    }
}
