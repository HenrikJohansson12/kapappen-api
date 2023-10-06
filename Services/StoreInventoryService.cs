using Microsoft.EntityFrameworkCore;

public class StoreInventoryService
{
    private readonly KapAppenDbContext _dbContext;

    public StoreInventoryService(KapAppenDbContext dbContext)
    {
        _dbContext = dbContext;
    }

  public async Task<IEnumerable<StoreInventory>> GetAvailableLengthsById(int productId)
{
    var storeInventory = await _dbContext.StoreInventories
        .Where(e => e.ProductId == productId) 
        .ToListAsync();

    return storeInventory;
}
}