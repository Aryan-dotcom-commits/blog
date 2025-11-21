using Microsoft.AspNetCore.Mvc;
using Server.Application.Interface;
using Server.Application.Services;

namespace Server.API.Controller;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("/all")]
    public async Task<IActionResult> GetAll()
    {
        var users = await _userRepository.GetAllUsers();
        return Ok(users);
    }

    [HttpGet("/user/{id}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        var usersById = await _userRepository.GetUserById(id);
        return Ok(usersById.username);
    }
}