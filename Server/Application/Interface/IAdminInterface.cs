using Domain.Entities;

public interface IAdminInterface
{
    Task<Admin?> GetAdmin(string usermail);
    Task<Admin?> AdminUser();
    Task<AdminProfile?> GetAdminProfile(Guid adminId);
    Task<Admin> LoginAdmin(string email, string password);
}