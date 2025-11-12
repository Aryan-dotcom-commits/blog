using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class UserRepo : IUserInterface
{
    private readonly ApplicationDbContext _context;

    public UserRepo(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task RegisterUser(RegisterDTO registerDTO)
    {
        var user = new User
        {
            userId = Guid.NewGuid(),
            userName = registerDTO.userName,
            userMail = registerDTO.userEmail,
            userPassword = registerDTO.userPassword
        };
        
        _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }
    
    public async Task<IEnumerable<User>> GetUser()
    {
        return await _context.Users.ToListAsync();
    }
}