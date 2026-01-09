using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Cyberpunk2020CharacterManager_network.Records;

namespace Cyberpunk2020CharacterManagerServer.Controllers;

[ApiController]
[Route("/auth")]
public class AuthTokenController : ControllerBase
{
    private readonly ILogger<AuthTokenController> _logger;

    private readonly IConfiguration _config;

    public AuthTokenController(ILogger<AuthTokenController> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }

    [HttpPost(Name = "Auth")]
    public async Task<IActionResult> Login([FromBody] AuthData authData)
    {
        _logger.LogInformation($"Попытка входа пользователя: {authData.Username}");

        // Ваш метод проверки пользователя
        if (!await IsCorrectUser(authData))
        {
            return Unauthorized("Неверное имя пользователя или пароль.");
        }

        var token = GenerateJwtToken(authData.Username);
        return Ok(new TokenDto() { Token = token});
    }

    private string GenerateJwtToken(string username)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Name, username),
            // Можно добавить роли: new Claim(ClaimTypes.Role, "Admin")
        };

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddHours(25), // Время жизни токена
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public async Task<bool> IsCorrectUser(AuthData authData)
    {
        return true;
    }
}
