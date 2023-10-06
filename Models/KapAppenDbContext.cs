using Microsoft.EntityFrameworkCore;

public class KapAppenDbContext : DbContext
{
      public KapAppenDbContext(DbContextOptions<KapAppenDbContext> options)
        : base(options)
    {
    }

    public DbSet<Store> Stores { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<StoreInventory> StoreInventories { get; set; } = null!;
}