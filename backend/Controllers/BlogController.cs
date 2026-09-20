using FazalTechSolutions.Api.Data;
using FazalTechSolutions.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FazalTechSolutions.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<BlogPost>> GetAll()
    {
        var posts = SeedData.BlogPosts.OrderByDescending(p => p.PublishedOn);
        return Ok(posts);
    }

    [HttpGet("{slug}")]
    public ActionResult<BlogPost> GetBySlug(string slug)
    {
        var post = SeedData.BlogPosts.FirstOrDefault(p =>
            p.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

        return post is null ? NotFound() : Ok(post);
    }
}
