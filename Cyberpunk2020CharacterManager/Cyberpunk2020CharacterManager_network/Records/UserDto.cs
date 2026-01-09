namespace Cyberpunk2020CharacterManager_network.Records;

public record UserDto
{
    public string Username { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string JwtToken { get; set; } = string.Empty;

    public string IpAddress { get; set; } = string.Empty;

    public string Port { get; set; } = string.Empty;
}
