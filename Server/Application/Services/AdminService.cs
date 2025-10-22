using Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Application.Services
{
    public class AdminService
    {
        private readonly IAdminInterface _adminRepo;

        public AdminService(IAdminInterface adminRepo)
        {
            _adminRepo = adminRepo;
        }

        public async Task<Admin?> GetAdminByEmail(string usermail)
        {
            var adminemail = await _adminRepo.GetAdmin(usermail);

            if (adminemail == null) throw new Exception("Admin not found");

            return adminemail;
        }

        public async Task<Admin?> GetAdminAsync()
        {
            var admin = await _adminRepo.AdminUser();

            if (admin == null) throw new Exception("Admin not found");

            return admin;
        }

        public async Task<AdminProfile?> GetAdminProfileByEmail(Guid adminId)
        {
            var adminProfile = await _adminRepo.GetAdminProfile(adminId);

            if (adminProfile == null) throw new Exception("Admin Profile not found");

            return adminProfile;
        }

        public async Task<Admin> LoginAdmin(string email, string password)
        {
            var admin = await _adminRepo.LoginAdmin(email, password);

            return admin;
        }
    }
}