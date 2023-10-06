public static class SeedDatabase
{
    public static void SeedData(KapAppenDbContext dbContext)
    {

        dbContext.Database.EnsureCreated();

        if (dbContext.Stores.Any())
        {
            return;
        }


        var stores = new List<Store>
        {
            new Store { Name = "Hornbach", Latitud = 57.7170224450738m, Longitud=12.886781464324267m},
            new Store { Name = "Byggmax",Latitud = 57.73276543799453m, Longitud=12.924147301675156m},
            new Store { Name = "XL-Bygg",Latitud = 57.70775372509438m, Longitud=12.92295156733552m},
        };
      
        var products = new List<Product>
        {
            new Product { Type = "Regel", Thickness = 45, Width = 45,IsPressureTreated = false},
            new Product { Type = "Regel", Thickness = 45, Width = 70,IsPressureTreated = false},
            new Product { Type = "Regel", Thickness = 45, Width = 95,IsPressureTreated = false},
            new Product { Type = "Regel", Thickness = 45, Width = 120,IsPressureTreated = false},
            new Product { Type = "Regel", Thickness = 45, Width = 145,IsPressureTreated = false},
            new Product { Type = "Regel", Thickness = 45, Width = 170,IsPressureTreated = false},
            new Product { Type = "Regel", Thickness = 45, Width = 190,IsPressureTreated = false},
            new Product { Type = "Regel", Thickness = 45, Width = 220,IsPressureTreated = false},
            new Product { Type = "Stolpe", Thickness = 70, Width = 70,IsPressureTreated = false},
            new Product { Type = "Stolpe", Thickness = 95, Width = 95,IsPressureTreated = false},
            new Product { Type = "Trall", Thickness = 28, Width = 120,IsPressureTreated = true},
            new Product { Type = "Trall", Thickness = 22, Width = 95,IsPressureTreated = true},
            new Product { Type = "Trall", Thickness = 28, Width = 145,IsPressureTreated = true},
            new Product { Type = "Trall", Thickness = 34, Width = 145,IsPressureTreated = true},
            
        };

        var storeInventory = new List<StoreInventory>
        {   //Hornbach
            new StoreInventory { StoreId = 1, ProductId = 1, Length = 2500},
            new StoreInventory { StoreId = 1, ProductId = 2, Length = 2500},
            new StoreInventory { StoreId = 1, ProductId = 3, Length = 2500},
            new StoreInventory { StoreId = 1, ProductId = 4, Length = 2500},
            new StoreInventory { StoreId = 1, ProductId = 5, Length = 2500},
            new StoreInventory { StoreId = 1, ProductId = 6, Length = 2500},
            new StoreInventory { StoreId = 1, ProductId = 7, Length = 2500},
            new StoreInventory { StoreId = 1, ProductId = 1, Length = 3600},
            new StoreInventory { StoreId = 1, ProductId = 2, Length = 3600},
            new StoreInventory { StoreId = 1, ProductId = 3, Length = 3600},
            new StoreInventory { StoreId = 1, ProductId = 4, Length = 3600},
            new StoreInventory { StoreId = 1, ProductId = 5, Length = 3600},
            new StoreInventory { StoreId = 1, ProductId = 6, Length = 3600},
            new StoreInventory { StoreId = 1, ProductId = 7, Length = 3600},
            new StoreInventory { StoreId = 1, ProductId = 1, Length = 4200},
            new StoreInventory { StoreId = 1, ProductId = 2, Length = 4200},
            new StoreInventory { StoreId = 1, ProductId = 3, Length = 4200},
            new StoreInventory { StoreId = 1, ProductId = 4, Length = 4200},
            new StoreInventory { StoreId = 1, ProductId = 5, Length = 4200},
            new StoreInventory { StoreId = 1, ProductId = 6, Length = 4200},
            new StoreInventory { StoreId = 1, ProductId = 7, Length = 4200},
            //Byggmax
            new StoreInventory { StoreId = 2, ProductId = 1, Length = 2700},
            new StoreInventory { StoreId = 2, ProductId = 2, Length = 2700},
            new StoreInventory { StoreId = 2, ProductId = 3, Length = 2700},
            new StoreInventory { StoreId = 2, ProductId = 4, Length = 2700},
            new StoreInventory { StoreId = 2, ProductId = 5, Length = 2700},
            new StoreInventory { StoreId = 2, ProductId = 6, Length = 2700},
            new StoreInventory { StoreId = 2, ProductId = 7, Length = 2700},
            new StoreInventory { StoreId = 2, ProductId = 1, Length = 3600},
            new StoreInventory { StoreId = 2, ProductId = 2, Length = 3600},
            new StoreInventory { StoreId = 2, ProductId = 3, Length = 3600},
            new StoreInventory { StoreId = 2, ProductId = 4, Length = 3600},
            new StoreInventory { StoreId = 2, ProductId = 5, Length = 3600},
            new StoreInventory { StoreId = 2, ProductId = 6, Length = 3600},
            new StoreInventory { StoreId = 2, ProductId = 7, Length = 3600},
            new StoreInventory { StoreId = 2, ProductId = 1, Length = 4800},
            new StoreInventory { StoreId = 2, ProductId = 2, Length = 4800},
            new StoreInventory { StoreId = 2, ProductId = 3, Length = 4800},
            new StoreInventory { StoreId = 2, ProductId = 4, Length = 4800},
            new StoreInventory { StoreId = 2, ProductId = 5, Length = 4800},
            new StoreInventory { StoreId = 2, ProductId = 6, Length = 4800},
            new StoreInventory { StoreId = 2, ProductId = 7, Length = 4800},
            //XL bygg alla brädor är 5.4 meter
            new StoreInventory { StoreId = 3, ProductId = 1, Length = 5400},   
            new StoreInventory { StoreId = 3, ProductId = 2, Length = 5400},   
            new StoreInventory { StoreId = 3, ProductId = 3, Length = 5400},   
            new StoreInventory { StoreId = 3, ProductId = 4, Length = 5400},   
            new StoreInventory { StoreId = 3, ProductId = 5, Length = 5400},   
            new StoreInventory { StoreId = 3, ProductId = 6, Length = 5400},
            new StoreInventory { StoreId = 3, ProductId = 7, Length = 5400},
            new StoreInventory { StoreId = 3, ProductId = 8, Length = 5400},
            new StoreInventory { StoreId = 3, ProductId = 9, Length = 5400},
            new StoreInventory { StoreId = 3, ProductId = 10, Length = 5400},
            new StoreInventory { StoreId = 3, ProductId = 11, Length = 5400},
            new StoreInventory { StoreId = 3, ProductId = 12, Length = 5400},
            new StoreInventory { StoreId = 3, ProductId = 13, Length = 5400}
        };
        
        dbContext.Stores.AddRange(stores);
        dbContext.SaveChanges();
        dbContext.Products.AddRange(products);
        dbContext.SaveChanges();
        dbContext.StoreInventories.AddRange(storeInventory);
        dbContext.SaveChanges();
    }
}