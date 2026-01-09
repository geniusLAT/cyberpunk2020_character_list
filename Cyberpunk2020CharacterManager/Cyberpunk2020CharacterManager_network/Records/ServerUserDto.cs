namespace Cyberpunk2020CharacterManager_network.Records;

public record ServerUserDto
{
    public string Username { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public bool IsGameMaster { get; set; } = true;
}
