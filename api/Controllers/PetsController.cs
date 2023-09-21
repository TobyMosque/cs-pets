using Microsoft.AspNetCore.Mvc;
using OpenApi.Pets.Sdk.Api;
using OpenApi.Pets.Sdk.Model;

namespace TobyMosque.Sample.Pets.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PetsController : ControllerBase
{
    private readonly ILogger<PetsController> _logger;
    private readonly IPetApi _petApi;

    public PetsController(ILogger<PetsController> logger, IPetApi petApi)
    {
        _logger = logger;
        _petApi = petApi;
    }

    [HttpGet]
    [ProducesResponseType(typeof(ICollection<Pet>), 200)]
    public async Task<IActionResult> GetAvailablePets()
    {
        var pets = await this._petApi.FindPetsByStatusAsync("available");
        return Ok(pets);
    }
}
