namespace Cyberpunk2020CharacterManager_network.Records;

public record AuthData
{
    public AuthData(string username, string passwordHash)
    {
        Username = username;
        PasswordHash = passwordHash;
    }

    public string Username { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;
}
