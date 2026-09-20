using System.Text.Json;
using FazalTechSolutions.Api.Models;

namespace FazalTechSolutions.Api.Services;

/// <summary>
/// Lightweight persistence for contact-form submissions: appends to a local
/// JSON file under App_Data. Good enough for a small marketing site; swap
/// for a real database (e.g. EF Core + SQL Server) if volume grows.
/// </summary>
public class JsonFileContactMessageStore : IContactMessageStore
{
    private readonly string _filePath;
    private readonly SemaphoreSlim _lock = new(1, 1);

    public JsonFileContactMessageStore(IWebHostEnvironment env)
    {
        var dataDir = Path.Combine(env.ContentRootPath, "App_Data");
        Directory.CreateDirectory(dataDir);
        _filePath = Path.Combine(dataDir, "contact-messages.json");
    }

    public async Task<ContactMessage> AddAsync(ContactMessage message)
    {
        await _lock.WaitAsync();
        try
        {
            var messages = await ReadAllInternalAsync();
            message.Id = messages.Count == 0 ? 1 : messages.Max(m => m.Id) + 1;
            message.SubmittedAtUtc = DateTime.UtcNow;
            messages.Add(message);

            var json = JsonSerializer.Serialize(messages, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_filePath, json);

            return message;
        }
        finally
        {
            _lock.Release();
        }
    }

    public async Task<IReadOnlyList<ContactMessage>> GetAllAsync()
    {
        await _lock.WaitAsync();
        try
        {
            return await ReadAllInternalAsync();
        }
        finally
        {
            _lock.Release();
        }
    }

    private async Task<List<ContactMessage>> ReadAllInternalAsync()
    {
        if (!File.Exists(_filePath))
        {
            return new List<ContactMessage>();
        }

        var json = await File.ReadAllTextAsync(_filePath);
        if (string.IsNullOrWhiteSpace(json))
        {
            return new List<ContactMessage>();
        }

        return JsonSerializer.Deserialize<List<ContactMessage>>(json) ?? new List<ContactMessage>();
    }
}
