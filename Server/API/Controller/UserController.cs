using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Microsoft.AspNetCore.Http.HttpResults;

[ApiController]
[Route("")]
public class UserController : ControllerBase
{
    private readonly UserService _admin;

    public UserController(UserService user)
    {
        _admin = user;
    }

    [HttpPost("api/registerUser")]
    public async Task<ApiResponse<User>> RegisterUsers([FromBody] RegisterDTO user)
    {
        return await _admin.RegisterUser(user);
    }

    [HttpGet("api/getAllUsers")]
    public async Task<IActionResult> GetUser()
    {
        return Ok(await _admin.GetUsers());
    }
}