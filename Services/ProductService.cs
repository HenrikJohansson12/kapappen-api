using Microsoft.EntityFrameworkCore;

public class ProductService
{
    private readonly KapAppenDbContext _dbContext;

    public ProductService(KapAppenDbContext dbContext)
    {
        _dbContext = dbContext;
    }

     public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _dbContext.Products.ToListAsync();
    }
}