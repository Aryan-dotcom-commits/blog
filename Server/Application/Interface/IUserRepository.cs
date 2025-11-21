using Domain.Entities;

namespace Server.Application.Interface;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsers();
    Task<User> GetUserById(Guid id);
    Task<User> SearchUserByName(String userName);
    Task<User> CreateUser(User user);
}