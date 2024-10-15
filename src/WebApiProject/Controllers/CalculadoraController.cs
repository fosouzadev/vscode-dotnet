using LibraryProject;
using Microsoft.AspNetCore.Mvc;

namespace WebApiProject.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Calc([FromServices] ICalculadora calculadora, [FromBody] SomarDto dto)
    {
        return Ok(calculadora.Somar(dto.Valores));
    }
}
