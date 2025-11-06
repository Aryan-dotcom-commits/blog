using Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Diagnostics;

namespace Application.Services
{
    public class AdminService
    {
        private readonly IAdminInterface _adminRepo;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AdminService(IAdminInterface adminRepo, IHttpContextAccessor httpContextAccessor)
        {
            _adminRepo = adminRepo;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ApiResponse<Admin>> RegisterAdmin(RegisterDTO admin)
        {
            try
                {
                    var adminDetails = new Admin
                    {
                        adminId = Guid.NewGuid(),
                        adminName = admin.adminName,
                        adminEmail = admin.adminEmail,
                        adminPassword = admin.adminPassword,
                        DOB = DateTime.SpecifyKind(admin.DOB, DateTimeKind.Utc),
                        Gender = Domain.Enums.Gender.Male,
                        TargetWeight = admin.TargetWeight,
                        ActivityLevel = admin.ActivityLevel,
                        createdAt = DateTime.UtcNow,
                    };

                await _adminRepo.RegisterAdmin(admin);

                if (admin.adminEmail == adminDetails.adminEmail) return new ApiResponse<Admin>
                {
                    Success = false,
                    Message = "Admin exists with the same email",
                    Data = adminDetails,
                    TraceId = _httpContextAccessor.HttpContext?.TraceIdentifier
                };

                var adminCount = (await _adminRepo.GetAdmin()).Count();
                if (adminCount > 0) return new ApiResponse<Admin>
                {
                    Success = false,
                    Message = "Admin exists with a different mail",
                    Data = adminDetails
                };

                return new ApiResponse<Admin>
                {
                    Success = true,
                    Message = "Admin registered successfully",
                    Data = adminDetails,
                    TraceId = _httpContextAccessor.HttpContext?.TraceIdentifier
                };
                    
                }
                catch (Exception ex)
                {
                    return new ApiResponse<Admin>
                    {
                        Success = false,
                        Message = $"Here is the stack trace: {ex.StackTrace}",
                        Data = null,
                        TraceId = _httpContextAccessor.HttpContext?.TraceIdentifier
                    };
                }
        }

        public async Task<IEnumerable<Admin>> GetAdmins()
        {
            return await _adminRepo.GetAdmin();
        }
    }
}