using MarvelRivals.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarvelRivals.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProxyController : ControllerBase
    {
        private readonly ExternalAPIService _service;

        public ProxyController(ExternalAPIService service)
        {
            _service = service;
        }

        [HttpGet("heroes")]
        public async Task<IActionResult> GetHeroes()
        {
            var names = await _service.GetHeroNamesAsync();
            return Ok(names);
        }
    }
}
