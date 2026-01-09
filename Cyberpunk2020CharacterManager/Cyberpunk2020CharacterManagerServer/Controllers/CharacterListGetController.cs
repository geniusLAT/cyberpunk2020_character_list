using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cyberpunk2020CharacterManagerServer.Controllers;

[ApiController]
[Authorize]
[Route("/my_characters")]
public class CharacterListGetController : ControllerBase
{
    private readonly ILogger<StabilityCheckController> _logger;

    public CharacterListGetController(ILogger<StabilityCheckController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCharacter")]
    public IEnumerable<StabilityResponse> Get()
    {
        _logger.LogInformation("GetStability");

        return [];
    }
}
