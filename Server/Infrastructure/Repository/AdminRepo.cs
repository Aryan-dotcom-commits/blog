using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class AdminRepo : IAdminInterface
{
    private readonly ApplicationDbContext _context;

    public AdminRepo(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task RegisterAdmin(RegisterDTO registerDTO)
    {
        var admin = new Admin
        {
            adminId = Guid.NewGuid(),
            adminName = registerDTO.adminName,
            adminEmail = registerDTO.adminEmail,
            adminPassword = registerDTO.adminPassword
        };
        
        _context.Admins.AddAsync(admin);
        await _context.SaveChangesAsync();
    }
    
    public async Task<IEnumerable<Admin>> GetAdmin()
    {
        return await _context.Admins.ToListAsync();
    }
}