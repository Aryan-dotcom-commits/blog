using Domain.Entities;

public interface IAdminInterface
{
    Task RegisterAdmin(RegisterDTO admin);
    Task<IEnumerable<Admin>> GetAdmin();
}