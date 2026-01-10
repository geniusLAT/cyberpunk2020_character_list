using Cyberpunk2020GameEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Cyberpunk2020CharacterManagerServer.Controllers;

[ApiController]
[Authorize]
[Route("/my_characters")]
public class CharacterListGetController : ControllerBase
{
    private readonly ILogger<CharacterListGetController> _logger;

    public CharacterListGetController(ILogger<CharacterListGetController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username))
        {
            return Unauthorized("Cannot identify user by his token");
        }

        _logger.LogInformation($"User {username} is requesting their character list.");

        string baseDataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        string userPath = Path.Combine(baseDataPath, username);

        if (!Directory.Exists(userPath))
        {
            return Ok(new List<Character>());
        }

        try
        {
            var files = Directory.GetFiles(userPath, "*.json");
            var characters = new List<Character>();

            foreach (var filePath in files)
            {
                try
                {
                    string json = await System.IO.File.ReadAllTextAsync(filePath);
                    var character = JsonSerializer.Deserialize<Character>(json);
                    if (character != null)
                    {
                        characters.Add(character);
                    }
                }
                catch (JsonException ex)
                {
                    _logger.LogWarning($"Failed to deserialize character file: {filePath}. Error: {ex.Message}");
                }
            }

            return Ok(characters);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error while reading characters for user {username}");
            return StatusCode(500, "Internal server error while fetching characters.");
        }
    }
}