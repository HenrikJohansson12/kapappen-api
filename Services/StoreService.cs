using Microsoft.EntityFrameworkCore;

public class StoreService
{
    private readonly KapAppenDbContext _dbContext;

    public StoreService(KapAppenDbContext dbContext)
    {
        _dbContext = dbContext;
    }

  public async Task<IEnumerable<Store>> GetAllStores()
{
    var storeList = await _dbContext.Stores.ToListAsync();
        

    return storeList;
}
}