using Cyberpunk2020GameEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Cyberpunk2020CharacterManagerServer.Controllers;

[ApiController]
[Authorize]
[Route("/save-character")]
public class SaveCharacterController : ControllerBase
{
    private readonly ILogger<SaveCharacterController> _logger;

    public SaveCharacterController(ILogger<SaveCharacterController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "SaveCharacter")]
    public async Task<IActionResult>  SaveCharacter([FromBody] Character character)
    {
        _logger.LogInformation($"SaveCharacter {character.name}");

        Console.WriteLine("Here");

        var username = User.Identity?.Name;

        if (string.IsNullOrEmpty(username))
        {
            return Unauthorized("Cannot identify user by his token");
        }

        _logger.LogInformation($"User {username} Saves {character.name}");

        try
        {
            string baseDataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string userPath = Path.Combine(baseDataPath, username);

            Directory.CreateDirectory(userPath);

            string fileName = $"{character.name}.json";
            string filePath = Path.Combine(userPath, fileName);

            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(character, jsonOptions);

            await System.IO.File.WriteAllTextAsync(filePath, json);

            return Ok(new { message = "Character was saved", path = filePath });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error during saving character {username}");
            return StatusCode(500, "Character saving error on the server.");
        }
    }
}
