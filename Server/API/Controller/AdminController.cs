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

    [HttpGet("api/admin")]
    public async Task<IActionResult> GetAdmin([FromQuery] string usermail)
    {
        try
        {
            if (string.IsNullOrEmpty(usermail))
            {
                return BadRequest("Email cannot be null or empty");
            }

            var admin = await _admin.GetAdminByEmail(usermail);

            if (admin == null) return NotFound("Admin not found");

            return Ok(admin);
        }
        catch (Exception e)
        {
            return StatusCode(500, new
            {
                Message = "An error occurred while processing your request.",
                Details = e.Message,
                trace = e.StackTrace
            });
        }
    }


    [HttpGet("api/admin/details")]
    public async Task<IActionResult> GetAdminDetails()
    {
        try
        {
            var admin = await _admin.GetAdminAsync();
            return Ok(admin);
        }
        catch (Exception e)
        {
            return StatusCode(500, new
            {
                Message = "An error occurred while processing your request.",
                Details = e.Message,
                trace = e.StackTrace
            });
        }
    }

    [HttpGet("api/admin/profile")]
    public async Task<IActionResult> GetAdminProfile([FromQuery] Guid adminId)
    {
        try
        {
            var profile = await _admin.GetAdminProfileByEmail(adminId);
            return Ok(profile);
        }
        catch (Exception e)
        {
            return StatusCode(500, new
            {
                Message = "An error occurred while processing your request.",
                Details = e.Message,
                trace = e.StackTrace
            });
        }
    }

    [HttpGet("api/admin/login")]
    public async Task<IActionResult> LoginAdmin([FromQuery] string email, string password)
    {
        try
        {
            var admin = await _admin.LoginAdmin(email, password);
            return Ok(admin);
        }

        catch (Exception e)
        {
            return StatusCode(500, new
            {
                Message = "An error occurred while processing your request.",
                Details = e.Message,
                trace = e.StackTrace
            });
        }
    }
}