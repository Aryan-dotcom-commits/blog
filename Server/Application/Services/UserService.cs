using Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Diagnostics;

namespace Application.Services
{
    public class UserService
    {
        private readonly IUserInterface _userRepo;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IUserInterface userRepo, IHttpContextAccessor httpContextAccessor)
        {
            _userRepo = userRepo;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ApiResponse<User>> RegisterUser(RegisterDTO user)
        {
            try
                {
                    var userDetails = new User
                    {
                        userId = Guid.NewGuid(),
                        userName = user.userName,
                        userMail = user.userEmail,
                        userPassword = user.userPassword,
                        DOB = DateTime.SpecifyKind(user.DOB, DateTimeKind.Utc),
                        Gender = Domain.Enums.Gender.Male,
                        TargetWeight = user.TargetWeight,
                        ActivityLevel = user.ActivityLevel,
                        createdAt = DateTime.UtcNow,
                    };

                await _userRepo.RegisterUser(user);

                if (user.userEmail == userDetails.userMail) return new ApiResponse<User>
                {
                    Success = false,
                    Message = "Admin exists with the same email",
                    Data = userDetails,
                    TraceId = _httpContextAccessor.HttpContext?.TraceIdentifier
                };

                var adminCount = (await _userRepo.GetUser()).Count();
                if (adminCount > 0) return new ApiResponse<User>
                {
                    Success = false,
                    Message = "Admin exists with a different mail",
                    Data = userDetails
                };

                return new ApiResponse<User>
                {
                    Success = true,
                    Message = "Admin registered successfully",
                    Data = userDetails,
                    TraceId = _httpContextAccessor.HttpContext?.TraceIdentifier
                };
                    
                }
                catch (Exception ex)
                {
                    return new ApiResponse<User>
                    {
                        Success = false,
                        Message = $"Here is the stack trace: {ex.StackTrace}",
                        Data = null,
                        TraceId = _httpContextAccessor.HttpContext?.TraceIdentifier
                    };
                }
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepo.GetUser();
        }
    }
}