namespace LSPLibrary
{
    public interface IPlayer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        PlayerCategory Category { get; set; }
        void SetCategory(PlayerCategory category);
        string GetMarketValue(PlayerCategory category);
    }
}