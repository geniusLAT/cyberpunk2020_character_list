using Cyberpunk2020CharacterManager_network.Records;
using Cyberpunk2020CharacterManager_network.Records;
using Cyberpunk2020CharacterManager_network.utils;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterManagerWindowsApp.ConnectionManagmentMenus;

internal class ConnectionManager
{
    private static readonly HttpClient _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(5) };

    public IEnumerable<UserDto> Users { get; set; } = [];

    public async Task<string> CheckConnection(string ipAddress, string port, string username, string password)
    {
        var sb = new StringBuilder();

        if (!IsValidIp(ipAddress))
            return "Ошибка: Неверный формат IP-адреса.";

        if (!IsValidPort(port, out int portNumber))
            return "Ошибка: Неверный формат порта (должен быть 1-65535).";

        var passwordHash = PasswordHasher.HashPassword(password);

        string url = $"http://{ipAddress}:{portNumber}/stability"; 

        try
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, url);

            var authString = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{passwordHash}"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authString);

            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return "Успешно: Соединение установлено.";
            }

            return $"Ошибка: Сервер ответил {response.StatusCode}";
        }
        catch (HttpRequestException ex)
        {
            return $"Ошибка сети: {ex.Message}";
        }
        catch (TaskCanceledException)
        {
            return "Ошибка: Превышено время ожидания (Timeout).";
        }
    }

    public async Task<string> AddNewServerAsync(string ipAddress, string port, string username, string password)
    {
        var passwordHash = PasswordHasher.HashPassword(password);

        var jwt = await AuthAsync(ipAddress, port, username, passwordHash);
        if (jwt is null)
        {
            return "Ошибка авторизации";
        }

        var addedUser = new UserDto()
        {
            Username = username,
            PasswordHash = passwordHash,
            JwtToken = jwt,
            IpAddress = ipAddress,
            Port = port
        };

        return SaveUserAsync(addedUser);
    }

    public async Task<string?> AuthAsync(string ipAddress, string port, string username, string passwordHash)
    {
        var sb = new StringBuilder();

        if (!IsValidIp(ipAddress))
            return null;

        if (!IsValidPort(port, out int portNumber))
            return null;

        string url = $"http://{ipAddress}:{portNumber}/auth";

        try
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, url);

            var authString = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{passwordHash}"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authString);

            var authData = new AuthData(username, passwordHash);

            var response = await _httpClient.PostAsJsonAsync(url, authData);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<
                    TokenDto
                    >();

                return result?.Token;
            }

            return response.Content.ToString();
        }
        catch (HttpRequestException ex)
        {
            return null;
        }
        catch (TaskCanceledException)
        {
            return null;
        }
    }

    private bool IsValidIp(string ip)
    {
        return IPAddress.TryParse(ip, out _);
    }

    private bool IsValidPort(string portStr, out int port)
    {
        return int.TryParse(portStr, out port) && port > 0 && port <= 65535;
    }

    public static string SaveUserAsync(UserDto user)
    {
        var subFolderName = $"{user.Username}@{user.IpAddress}";

        string rootPath = AppDomain.CurrentDomain.BaseDirectory;

        string dataPath = Path.Combine(rootPath, "Data");
        string projectPath = Path.Combine(dataPath, subFolderName);
        string charactersPath = Path.Combine(projectPath, "cashedCharacters");
        string userInfoFilePath = Path.Combine(projectPath, "userinfo.json");

        try
        {
            Directory.CreateDirectory(charactersPath);

            if (!File.Exists(userInfoFilePath))
            {
                string json = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(userInfoFilePath, json);
            }
            else
            {
                return "Пользователь уже закеширован";
            }
        }
        catch (Exception ex)
        {
            // В GUI важно уведомлять пользователя о проблемах с правами доступа
            return $"Ошибка: {ex.Message}";
        }

        return string.Empty;
    }
}

