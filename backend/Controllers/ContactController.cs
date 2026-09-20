using FazalTechSolutions.Api.Models;
using FazalTechSolutions.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FazalTechSolutions.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{
    private readonly IContactMessageStore _store;
    private readonly ILogger<ContactController> _logger;

    public ContactController(IContactMessageStore store, ILogger<ContactController> logger)
    {
        _store = store;
        _logger = logger;
    }

    /// <summary>
    /// Receives a submission from the public contact form.
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<ContactMessage>> Submit([FromBody] ContactMessage message)
    {
        if (!ModelState.IsValid)
        {
            return ValidationProblem(ModelState);
        }

        var saved = await _store.AddAsync(message);
        _logger.LogInformation("New contact message received from {Email} (#{Id})", saved.Email, saved.Id);

        return CreatedAtAction(nameof(Submit), new { id = saved.Id }, saved);
    }
}
