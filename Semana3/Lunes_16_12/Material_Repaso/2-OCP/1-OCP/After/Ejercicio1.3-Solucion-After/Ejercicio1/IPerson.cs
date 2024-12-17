namespace Ejercicio1
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccountService IAccountService { get; set; }
    }
}