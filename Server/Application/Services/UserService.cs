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

    public async Task<ApiResponse<User>> GetUserById(Guid id)
    {
        try
        {
            var userbyId = await _userRepo.GetUserById(id);

            if (userbyId == null)
                return new ApiResponse<User>
                {
                    Message = "No user of this ID can be found",
                    Success = true,
                    Data = null
                };

            if (userbyId.Equals(false))
                return new ApiResponse<User>
                {
                    Message = "DB is empty",
                    Success = true,
                    Data = null
                };
            
            var user = new User
            {
                username = userbyId.username,
                useremail = userbyId.useremail
            };

            return new ApiResponse<User>
            {
                Message = "User found",
                Success = true,
                Data = null
            };
        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }
}