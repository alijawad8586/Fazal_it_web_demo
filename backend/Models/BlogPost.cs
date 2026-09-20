namespace FazalTechSolutions.Api.Models;

public class BlogPost
{
    public int Id { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Excerpt { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string ReadTime { get; set; } = string.Empty;

    /// <summary>
    /// Byline is always the company, never an individual staff name.
    /// </summary>
    public string Author { get; set; } = "Fazal Tech Solutions Team";
    public DateOnly PublishedOn { get; set; }
}
