using Microsoft.AspNetCore.Mvc;

namespace Kapappen_api.Controllers;

[ApiController]
[Route("[controller]")]
public class StoreController : ControllerBase
{
    private readonly StoreService _storeService;

    public StoreController(StoreService storeService)
    {
        _storeService = storeService;
    }

      [HttpGet]
    public async Task<ActionResult<IEnumerable<Store>>> GetAllProducts()
    {
        try
        {
            var result = await _storeService.GetAllStores();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }
}