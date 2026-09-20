using System.ComponentModel.DataAnnotations;

namespace FazalTechSolutions.Api.Models;

/// <summary>
/// A message submitted through the public "Contact Us" form.
/// No personal contact details (staff names, office location, phone numbers)
/// are stored anywhere in this API by design — only what the visitor supplies.
/// </summary>
public class ContactMessage
{
    public int Id { get; set; }

    [Required, MaxLength(120)]
    public string Name { get; set; } = string.Empty;

    [Required, EmailAddress, MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    [MaxLength(150)]
    public string? Subject { get; set; }

    [Required, MaxLength(4000)]
    public string Message { get; set; } = string.Empty;

    public DateTime SubmittedAtUtc { get; set; } = DateTime.UtcNow;
}
