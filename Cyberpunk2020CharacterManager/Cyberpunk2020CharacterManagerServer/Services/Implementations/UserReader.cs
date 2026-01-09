using Cyberpunk2020CharacterManager_network.Records;
using System.Text.Json;

namespace Cyberpunk2020CharacterManagerServer.Services.Interfaces;

public class UserReader : IUserReader
{
    private readonly ILogger<IUserReader> _logger;

    private IEnumerable<ServerUserDto>? Users;

    public UserReader(ILogger<IUserReader> logger)
    {
        _logger = logger;
        var task = Task.Run(() => ReadUsers());
        task.Wait();
        Users = task.Result;
    }

    public async Task<IEnumerable<ServerUserDto>> ReadUsers()
    {
        if (Users is null)
        {
            Users = await ReadUsersFromMemory();
        }
        return Users;
    }

    public async Task<IEnumerable<ServerUserDto>> ReadUsersFromMemory()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userdata.json");

        if (!File.Exists(filePath))
        {
            return new List<ServerUserDto>();
        }

        try
        {
            using FileStream openStream = File.OpenRead(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = false
            };

            var users = await JsonSerializer.DeserializeAsync<IEnumerable<ServerUserDto>>(openStream, options);

            return users?.ToList() ?? new List<ServerUserDto>();
        }
        catch (JsonException ex)
        {
            // Логируем ошибку десериализации
            _logger.LogError($"deserialization error: {ex.Message}");
            return new List<ServerUserDto>();
        }
        catch (Exception ex)
        {
            _logger.LogError($"file was currupted: {ex.Message}");
            return new List<ServerUserDto>();
        }
    }
}
