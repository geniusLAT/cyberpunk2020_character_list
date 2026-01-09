using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterManagerWindowsApp.ConnectionManagmentMenus;

internal class ConnectionManager
{
    private static readonly HttpClient _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(5) };

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

    public async Task<string> AuthAsync(string ipAddress, string port, string username, string password)
    {
        var sb = new StringBuilder();

        if (!IsValidIp(ipAddress))
            return "Ошибка: Неверный формат IP-адреса.";

        if (!IsValidPort(port, out int portNumber))
            return "Ошибка: Неверный формат порта (должен быть 1-65535).";

        var passwordHash = PasswordHasher.HashPassword(password);

        string url = $"http://{ipAddress}:{portNumber}/auth";

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

            return response.Content.ToString();
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

    private bool IsValidIp(string ip)
    {
        return IPAddress.TryParse(ip, out _);
    }

    private bool IsValidPort(string portStr, out int port)
    {
        return int.TryParse(portStr, out port) && port > 0 && port <= 65535;
    }
}

