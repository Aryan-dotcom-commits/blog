using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class AdminRepo : IAdminInterface
{
    private readonly ApplicationDbContext _context;

    public AdminRepo(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Admin?> GetAdmin(string usermail)
    {
        return await _context.Admins.Where(a => a.adminEmail == usermail).FirstOrDefaultAsync();
    }

    public async Task<Admin?> AdminUser()
    {
        return await _context.Admins.FirstOrDefaultAsync();
    }

    public async Task<AdminProfile?> GetAdminProfile(Guid adminId)
    {
        var admin = await _context.Admins.Where(a => a.adminId == adminId).FirstOrDefaultAsync();

        return await _context.AdminProfiles.Where(ap => ap.profileId == admin.adminId).FirstOrDefaultAsync();
    }

    public async Task<Admin> LoginAdmin(string email, string password)
    {
       return await _context.Admins.Where(a => a.adminEmail == email && a.adminPassword == password).FirstOrDefaultAsync();
    }
}