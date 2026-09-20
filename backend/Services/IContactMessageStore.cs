using FazalTechSolutions.Api.Models;

namespace FazalTechSolutions.Api.Services;

public interface IContactMessageStore
{
    Task<ContactMessage> AddAsync(ContactMessage message);
    Task<IReadOnlyList<ContactMessage>> GetAllAsync();
}
