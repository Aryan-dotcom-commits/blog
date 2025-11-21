using Server.Application.Interface;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Server.Infrastructure.Database;

namespace Server.Infrastructure.Repository;

public class UserRepo : IUserRepository
{
    private readonly ApplicationDBContext _dbContext;

    public UserRepo(ApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await _dbContext.User.ToListAsync();
    }

    public async Task<User> GetUserById(Guid id)
    {
        return await _dbContext.User.FindAsync(id);
    }

    public async Task<User> SearchUserByName(string userName)
    {
        return await _dbContext.User.FirstOrDefaultAsync(u => u.username == userName);
    }

    public async Task<User> CreateUser(User user)
    {
        await _dbContext.User.AddAsync(user);
        await _dbContext.SaveChangesAsync();
        return user;
    }
}