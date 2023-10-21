using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
    
    [HttpGet]
    [Route("show-name")]
    public IActionResult ShowFullNama(String fullName)
    {
        return Ok(string.Format($"Usuário: {fullName}"));
    }
}
