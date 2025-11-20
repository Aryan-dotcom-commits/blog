using Server.Infrastructure.Repository;
using Domain.Entities;
using Server.Application.DTO;
namespace Server.Application.Services;

public class UserService
{
    private readonly UserRepo _userRepo;

    public UserService(UserRepo userRepo)
    {
        _userRepo = userRepo;
    }

    public async Task<ApiResponse<IEnumerable<UserDTO>>> GetAllUsers()
    {
        try
        {
            var users = await _userRepo.GetAllUsers();

            if (users == null)
            {
                return new ApiResponse<IEnumerable<UserDTO>>
                {
                    Message = "No users found",
                    Success = true,
                    Data = null
                };
            }

            var userDTO = users.Select(s => new UserDTO
            {
                UserName = s.username,
                UserMail = s.useremail
            });

            return new ApiResponse<IEnumerable<UserDTO>>
            {
                Message = "Users fetched successfully",
                Success = true,
                Data = userDTO
            };
        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }
}