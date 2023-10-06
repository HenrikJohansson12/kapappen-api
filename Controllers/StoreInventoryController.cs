using Microsoft.AspNetCore.Mvc;

namespace Kapappen_api.Controllers;

[ApiController]
[Route("[controller]")]
public class StoreInventoryController : ControllerBase
{
    private readonly StoreInventoryService _storeInventoryService;

    public StoreInventoryController(StoreInventoryService storeInventoryService)
    {
        _storeInventoryService = storeInventoryService;
    }


[HttpGet("{productId}")]
    public async Task<ActionResult<StoreInventory>> GetStoreInventoryByProductId(int productId)
    {
        try
        {
            var result = await _storeInventoryService.GetAvailableLengthsById(productId);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

}