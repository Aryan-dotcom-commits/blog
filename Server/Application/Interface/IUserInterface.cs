using Domain.Entities;

public interface IUserInterface
{
    Task RegisterUser(RegisterDTO user);
    Task<IEnumerable<User>> GetUser();
}