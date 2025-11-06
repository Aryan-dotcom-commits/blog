using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Microsoft.AspNetCore.Http.HttpResults;

[ApiController]
[Route("")]
public class AdminController : ControllerBase
{
    private readonly AdminService _admin;

    public AdminController(AdminService admin)
    {
        _admin = admin;
    }

    [HttpPost("api/registerAdmin")]
    public async Task<ApiResponse<Admin>> RegisterAdmin([FromBody] RegisterDTO admin)
    {
        return await _admin.RegisterAdmin(admin);
    }

    [HttpGet("api/getAdmin")]
    public async Task<IActionResult> GetAdmin()
    {
        return Ok(await _admin.GetAdmins());
    }
}