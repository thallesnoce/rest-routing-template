using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoutingTemplate.Data;

namespace RoutingTemplate.Controllers;

[ApiController]
[Route("api/v1/chefes")]
public class ChefesController(AppDbContext db) : ControllerBase
{
    // Etapa 1 — GET /api/v1/chefes
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {   
        var chefes = await db.Chefes.ToListAsync();
        return Ok(chefes);
    }

    // TODO Etapa 2: GET /api/v1/chefes/{id}

    // TODO Etapa 3: GET /api/v1/chefes/{id}/subordinados

    // TODO Etapa 4: GET /api/v1/chefes/{id}/subordinados/{subId}
}
