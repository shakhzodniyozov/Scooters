using Microsoft.AspNetCore.Mvc;

namespace Scooters.Controllers;

[Route("[controller]")]
public class ScooterController : Controller
{
    private readonly ILogger<ScooterController> _logger;

    public ScooterController(ILogger<ScooterController> logger)
    {
        _logger = logger;
    }
}