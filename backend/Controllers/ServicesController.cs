using FazalTechSolutions.Api.Data;
using FazalTechSolutions.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FazalTechSolutions.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<ServiceItem>> GetAll()
    {
        return Ok(SeedData.Services);
    }

    [HttpGet("{slug}")]
    public ActionResult<ServiceItem> GetBySlug(string slug)
    {
        var service = SeedData.Services.FirstOrDefault(s =>
            s.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

        return service is null ? NotFound() : Ok(service);
    }
}
