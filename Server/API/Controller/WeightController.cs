using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Services;


[ApiController]
[Route("")]
public class WeightController : ControllerBase
{
    private readonly WeightServices _weightServices;

    public WeightController(WeightServices weightServices)
    {
        _weightServices = weightServices;
    }

    [HttpGet("api/getWeight")]
    public async Task<IActionResult> GetWeights()
    {
        return Ok(await _weightServices.GetWeights());
    }

    [HttpPost("api/addWeight")]
    public async Task<IActionResult> AddWeights(WeightLogs weight)
    {
        return Ok(await _weightServices.AddWeightInfo(weight));
    }
}