using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public static class SeedAdminUser
{
   
    public static void SeedAdmin(ApplicationDbContext context)
    {
        var admin = new Admin
        {
            adminId = new System.Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
            adminName = "Aryan",
            adminEmail = "aryanpradhan773@gmail.com",
            adminPassword = "aryan",
            createdAt = new DateTime(2025, 10, 21, 0, 0, 0, DateTimeKind.Utc)
        };

        context.Admins.Add(admin);
        context.SaveChanges();
        
    }
}